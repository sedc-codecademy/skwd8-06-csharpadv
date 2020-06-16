using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionMethods.Helpers
{
    public static class StringHelper
    {
        public static string Shorten(this string text, int count)
        {
            if (count < 0)
            {
                throw new ArgumentException("Count cant be less then 0");
            }
            if (text.Length == 0)
            {
                return "";
            }
            string[] textWords = text.Split(" ");
            if(count > textWords.Length)
            {
                return text;
            }
            var substring = textWords.Take(count).ToList();
            var result = string.Join(" ", substring);
            return result + "...";
        }
    }
}
