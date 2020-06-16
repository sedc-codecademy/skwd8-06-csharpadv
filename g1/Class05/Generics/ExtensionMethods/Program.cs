
using ExtensionMethods.Helpers;
using System;
using System.Collections.Generic;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello from G1, we are learning C Sharp Advanced";
            var result = text.Shorten(5);
            Console.WriteLine(result);

            List<string> strings = new List<string>() { "str1", "str2", "str3" };
            List<int> ints = new List<int>() { 5, 22, -18 };
            List<bool> bools = new List<bool> { true, false, true };

            strings.GoThrough();
            strings.GetInfo();
            ints.GoThrough();
            ints.GetInfo();
            bools.GoThrough();
            bools.GetInfo();
        }
    }
}
