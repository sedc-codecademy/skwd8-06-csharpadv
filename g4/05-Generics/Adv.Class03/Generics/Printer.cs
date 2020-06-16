using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public static class Printer
    {
        public static void PrintStrings(List<string> strings)
        {
            foreach (var item in strings)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintInts(List<int> ints)
        {
            foreach (var item in ints)
            {
                Console.WriteLine(item);
            }
        }

        public static void PrintDoubles(List<double> doubles)
        {
            foreach (var item in doubles)
            {
                Console.WriteLine(item);
            }
        }

        public static void Print<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }

    }
}
