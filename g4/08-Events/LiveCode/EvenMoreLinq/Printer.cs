using System;
using System.Collections.Generic;
using System.Text;

namespace EvenMoreLinq
{
    public static class Printer
    {
        public static void Print<T>(this IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }

        public static void Print<T>(this IEnumerable<T> source, Func<T, string> processor)
        {
            foreach (var item in source)
            {
                Console.WriteLine(processor(item));
            }
        }

        public static void Print<T>(this IEnumerable<T> source, Func<T, int, string> processor)
        {
            var index = 0;
            foreach (var item in source)
            {
                Console.WriteLine(processor(item, index));
                index += 1;
            }
        }

    }
}
