using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ChatP2P
{
    public class Crypto
    {
        static public BigInteger PrimeNum;
        static public BigInteger q;
        static public BigInteger Gen;
        static public BigInteger PrivateSelf;
        private static uint random = 0;
        static public BigInteger PublicSelf;
        static public BigInteger PublicRemote;
        static public BigInteger SessionKey;

        private const int Keysize = 256;
        private const int DerivationIterations = 1000;


        public static string Encrypt(string plainText)
        {
            var passPhrase = SessionKey.ToString(); 
            var saltStringBytes = GenerateBitsOfRandomEntropy();
            var ivStringBytes = GenerateBitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(string cipherText)
        {
            var passPhrase = SessionKey.ToString();
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            using (var streamReader = new StreamReader(cryptoStream, Encoding.UTF8))
                            {
                                return streamReader.ReadToEnd();
                            }
                        }
                    }
                }
            }
        }

        private static byte[] GenerateBitsOfRandomEntropy(int bytes = 32)
        {
            var randomBytes = new byte[bytes]; 
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        public static BigInteger ComputeInitMsg()
        {
            return BigInteger.ModPow(Gen, random, PrimeNum);
        }

        public static void ComputeSessionkey(BigInteger RemoteMsg)
        {
            SessionKey = BigInteger.ModPow(BigInteger.ModPow(RemoteMsg, PrivateSelf, PrimeNum) * BigInteger.ModPow(PublicRemote, PrivateSelf, PrimeNum), 1, PrimeNum);
        }

        static bool IsPrime(int n)
        {
            if (n > 1)
            {
                return Enumerable.Range(1, n).Where(x => n % x == 0).SequenceEqual(new[] { 1, n });
            }

            return false;
        }
     
        //Miller-Rabin
        public static bool IsProbablePrime(BigInteger source, int certainty)
        {
            if (source == 2 || source == 3)
                return true;
            if (source < 2 || source % 2 == 0)
                return false;

            BigInteger d = source - 1;
            int s = 0;

            while (d % 2 == 0)
            {
                d /= 2;
                s += 1;
            }
  
            RandomNumberGenerator rng = RandomNumberGenerator.Create();
            byte[] bytes = new byte[source.ToByteArray().LongLength];
            BigInteger a;

            for (int i = 0; i < certainty; i++)
            {
                do
                {
                    rng.GetBytes(bytes);
                    a = new BigInteger(bytes);
                }
                while (a < 2 || a >= source - 2);

                BigInteger x = BigInteger.ModPow(a, d, source);
                if (x == 1 || x == source - 1)
                    continue;

                for (int r = 1; r < s; r++)
                {
                    x = BigInteger.ModPow(x, 2, source);
                    if (x == 1)
                        return false;
                    if (x == source - 1)
                        break;
                }

                if (x != source - 1)
                    return false;
            }

            return true;
        }

        List<BigInteger> GenerateDivisors(BigInteger number)
        {
            var primes = new List<BigInteger>();

            for (BigInteger div = 2; div <= number/2; div++)
                while (number % div == 0)
                {
                    if (IsProbablePrime(div, 10)) primes.Add(div);
                    number = number / div;
                }

            return primes;
        }       

        public static List<int> Primes = File.ReadAllLines(@"./primes.txt").ToList().ConvertAll<int>(Convert.ToInt32);

        public Crypto()
        {
            var order = Int32.Parse(File.ReadAllText(@"./order.txt"));
            File.WriteAllText(@"./order.txt", ((order + 1 ) % 2).ToString());
            string text = File.ReadAllText(@"./data"+order+".txt");
            var jsonObject = JObject.Parse(text);

            PrimeNum = BigInteger.Parse((string)jsonObject["PrimeNum"]);
            q = (Int64)jsonObject["q"];
            Gen = (Int64)jsonObject["Gen"];
            PrivateSelf = BigInteger.Parse((string)jsonObject["PrivateSelf"]);
            PublicRemote = BigInteger.Parse((string)jsonObject["PublicRemote"]); ;
/*
            PrimeNum = 1;
            while (!IsProbablePrime(PrimeNum, 10))
            {
                PrimeNum = new BigInteger(GenerateBitsOfRandomEntropy(128));
            }

            q = Primes.Where(x => ((PrimeNum - 1) % x == 0 )).Last();
            var qGroup = Enumerable.Range(1, (int)q-1).ToList(); //cyclic group

            Gen = 3;
            PrivateSelf = new BigInteger(GenerateBitsOfRandomEntropy(16));  */
            var randomize = new Random();
            random = (uint)randomize.Next(0, 10);
            //random = (uint)(number + (uint)Int32.MaxValue);           
            PublicSelf = BigInteger.ModPow(PrivateSelf, Gen, PrimeNum);
            

        }
        //static Crypto() => ;

    }
}
