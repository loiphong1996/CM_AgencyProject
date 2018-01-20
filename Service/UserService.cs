using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Service
{
    public static class UserService
    {
        public static User GetUser(string username, string password)
        {
            if (username.StartsWith("user") && password == "1234")
            {
                return new User
                {
                    Username = username,
                    Password = password
                };
            }

            if (username.StartsWith("admin") && password == "1234")
            {
                return new User
                {
                    Username = username,
                    Password = password
                };
            }

            return null;
        }
    }
}
