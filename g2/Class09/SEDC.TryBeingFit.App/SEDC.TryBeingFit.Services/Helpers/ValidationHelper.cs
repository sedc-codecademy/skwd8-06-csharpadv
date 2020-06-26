using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace SEDC.TryBeingFit.Services.Helpers
{
    public static class ValidationHelper
    {
        public static int ValidateNumber(string number, int range)
        {
            int num = 0;
            bool isNumber = int.TryParse(number, out num);
            if (!isNumber) return -1;
            if (num <= 0 || num > range) return -1;

            return num;
        }

        public static string ValidateName(string str, int length)
        {
            if (str.Length < length) return null;
            return str;
        }

        public static string ValidatePassword(string password)
        {
            if (password.Length < 6) return null;
            int num = 0;

            // another option as Stefan suggested
            //bool isNum = password.ToCharArray().Any(char.IsDigit);

            bool isNum = false;
            foreach (char item in password)
            {
                isNum = int.TryParse(item.ToString(), out num);
            }
            if (!isNum) return null;
            return password;
            

        }
    }
      
}
