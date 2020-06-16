using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> strings = new List<string>() { "str1", "str2", "str3", "str4" };
            //NonGenericHelpers.GoThrough(strings);
            //Console.WriteLine("-----------------------------------");
            //NonGenericHelpers.GetInfo(strings);
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };
            //NonGenericHelpers.GoThrough(numbers);
            //NonGenericHelpers.GetInfo(numbers);

            List<bool> bools = new List<bool>() { true, true, false, true, false };
            //GenericListHelpers.SaySomething("eve ti string");
            //GenericListHelpers.GetInfo(numbers);
            //GenericListHelpers.GetInfo(bools);
            

        }
    }
}
