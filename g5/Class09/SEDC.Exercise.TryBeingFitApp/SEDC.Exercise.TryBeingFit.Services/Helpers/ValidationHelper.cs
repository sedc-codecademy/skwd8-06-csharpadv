using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        public static string ValidatePassword(string password)
        {
            //andrej10  and10rej
            if (password.Length < 6) return null;
            int num;
            bool isNum = false;
            foreach (char item in password)
            {
                isNum = int.TryParse(item.ToString(), out num);
            }
            if (!isNum) return null;

            return password;
        }

        public static int ValidateNumber(string number, int range)
        {
            int num = 0;
            bool isNumber = int.TryParse(number, out num);
            if (!isNumber) return -1;
            if (num <= 0 || num > range) return -1;

            return num;
        }

        public static void ValidateString(string str)
        {
            throw new NotImplementedException();
        }

        public static void ValidateUserName(string username)
        {
            throw new NotImplementedException();
        }
    }
}
