using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adc.Class05.Generics.Helpers
{
    public class ListHelpers
    {
        public void GoThrough<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void GetInfo<T>(List<T> list)
        {
            T first = list[0];
            Console.WriteLine($"This list has {list.Count} members of type {first.GetType().Name}");
        }

        public void GoThroughStrings(List<string> listOfStrings)
        {
            foreach (var str in listOfStrings)
            {
                Console.WriteLine(str);
            }
        }

        public void GetInfoForStrings(List<string> listOfStrings)
        {
            string first = listOfStrings[0];
            Console.WriteLine($"This list has {listOfStrings.Count} members of type {first.GetType().Name}");
        }

        public void GoThroughIntegers(List<int> listOfIntegers)
        {
            foreach (var integer in listOfIntegers)
            {
                Console.WriteLine(integer);
            }
        }

        public void GetInfoForIntegers(List<int> listOfIntegers)
        {
            int first = listOfIntegers[0];
            Console.WriteLine($"This list has {listOfIntegers.Count} members of type {first.GetType().Name}");
        }

        public void GoThroughDoubles(List<double> listOfDoubles)
        {

        }
    }
}
