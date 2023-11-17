using System.Collections.Generic;
using System.Net;

namespace ChatP2P
{
    class ChatBehaviour
    {
        public List<User> UserList = new List<User>();
        public string WhatIsThis(string message, IPEndPoint address)
        {
            if (message[0] == '0')
            {
                string name;
                name = message.Substring(1);
                return name + " have just connected!";
            }
            return "";
        }
    }
}
