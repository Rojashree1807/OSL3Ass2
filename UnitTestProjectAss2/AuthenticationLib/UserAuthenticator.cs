using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationLib
{
    public class UserAuthenticator
    {
        private Dictionary<string, string> userDatabase = new Dictionary<string, string>();

        public bool RegisterUser(string username, string password)
        {
            if (!userDatabase.ContainsKey(username))
            {
                userDatabase.Add(username, password);
                return true;
            }

            return false;
        }

        public bool LoginUser(string username, string password)
        {
            if (userDatabase.TryGetValue(username, out string storedPassword))
            {
                return password == storedPassword;
            }

            return false;
        }

       
    }
}