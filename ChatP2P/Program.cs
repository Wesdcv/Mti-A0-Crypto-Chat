using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ChatP2P
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(Exception);
            Application.Run(new MainForm());
        }

        private static void Exception(object sender, ThreadExceptionEventArgs e)
        {
            File.AppendAllText(Environment.CurrentDirectory + @"\Log.txt", "[ERROR] at " + DateTime.Now + " – " + e.Exception.Message + Environment.NewLine);
        }
    }
}
