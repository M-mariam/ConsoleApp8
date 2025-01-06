using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterfaceQ2
{
    internal class BasicAuthenticationService : IAuthenticationService
    {

        private Users[] users;

        public BasicAuthenticationService()
        {
            users = new Users[]
            {
                new Users { Username = "admin", Password = "admin123", Role = "admin" },
                new Users { Username = "user", Password = "admin123", Role = "user" },
                new Users { Username = "admin2", Password = "admin123", Role = "admin2" }
            };
        }

        public bool AuthenticateUser(string username, string password)
        {
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            foreach (var user in users)
            {
                if (user.Username == username && user.Role == role)
                {
                    return true;
                }
            }
            return false;
        }
    }
    }

