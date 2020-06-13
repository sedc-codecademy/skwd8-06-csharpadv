using System;
using System.Collections.Generic;
using System.Linq;
using SEDC.Adv.Class05.ExtensionMethods.Entities;
using SEDC.Adv.Class05.ExtensionMethods.Helpers;

namespace SEDC.Adv.Class05.ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // why piggy backing
            //var p = new Product();
            //p.GetProductId();

            string text = "C# Advanced is an awesome subject with great demos and activities!";
            text.QuoteStringPiggybacking();
            Console.WriteLine(text.Shorten(2));

            string shortenQuotetText = text.Shorten(6).QuoteString();
            Console.WriteLine(shortenQuotetText);


            var listOfStrings = new List<string>() { "Trajan", "Goce", "Tosho", "Dragan" };
            var listOfIntegers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            var listOfDoubles = new List<double>() { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
            var listOfBooleans = new List<bool>() { true, false, true, false };

            listOfStrings.GetInfoPiggybacking();

            //listOfStrings.GoThrough();
            //listOfIntegers.GoThrough();
            //listOfDoubles.GoThrough();
            //listOfBooleans.GoThrough();

            listOfStrings.GetInfo<string>().GoThrough<string>();
            listOfIntegers.GetInfo().GoThrough();
            listOfDoubles.GetInfo<double>().GoThrough<double>();
            listOfBooleans.GetInfo().GoThrough();

            Console.ReadLine();
        }
    }
}
