using System;
using System.Collections.Generic;
using System.Text;

namespace Statics
{
    public static class BadStatic
    {
        public static string UserName { get; private set; }

        public static string Password { get; private set; }

        public static void SetUser(string username, string password)
        {
            UserName = username;
            Password = password;
        }
    }

    public class UserManager
    {
        public string UserName { get; private set; }

        public string Password { get; private set; }

        public void SetUser(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public UserManager Impersonate()
        {
            var result = new UserManager();
            result.SetUser("Admin", Password);
            return result;
        }
    }
}

