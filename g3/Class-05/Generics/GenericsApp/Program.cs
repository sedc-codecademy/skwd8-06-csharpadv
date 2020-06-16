using Domain;
using System;
using System.Collections.Generic;

namespace GenericsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string> { "231", "dewjan", "3kjhg434" };
            //List<int> ints = new List<int> { 22, 31, 4, 213123123, 321312 };

            foreach (var item in strings)
            {
                //Console.WriteLine(item.Trim());
            }

            StringList stringListStatic = new StringList();
            stringListStatic.Add("231");
            stringListStatic.Add("321312");
            stringListStatic.Add("Alek");
            stringListStatic.Add("dsadsadsada");

            stringListStatic.Print();
            Console.WriteLine($"The count if StringList is: {stringListStatic.Count}");

            AnyList<string> stringListGeneric = new AnyList<string>();
            AnyList<int> intListGeneric = new AnyList<int>();


            #region AnyList
            stringListGeneric.Add("new stuff");
            stringListGeneric.Add("alek generic");
            stringListGeneric.Add("dsaddsadasdsadhgsajkdhhgsa");

            stringListGeneric.Print();
            Console.WriteLine($"The count if AnyList is: {stringListGeneric.Count}");

            intListGeneric.Add(32);
            intListGeneric.Add(3213);
            intListGeneric.Add(45321);

            intListGeneric.Print();
            Console.WriteLine($"The count if AnyList is: {intListGeneric.Count}");
            #endregion

            Console.ReadKey();
        }
    }
}
