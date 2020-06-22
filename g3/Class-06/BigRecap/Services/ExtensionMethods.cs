using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public static class ExtensionMethods
    {
        public static int ToInt(this string str)
        {
            int result;

            if (int.TryParse(str, out result))
            {
                return result;
            }

            return 0;
        }

        public static int ToInt(this string str, DateTime dateTime)
        {
            Console.WriteLine(dateTime.ToString());
            int result;

            if (int.TryParse(str, out result))
            {
                return result;
            }

            return 0;
        }
    }
}
