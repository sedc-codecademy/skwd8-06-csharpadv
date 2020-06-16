using System;
using System.Collections.Generic;
using System.Text;

namespace Generics.Helpers
{
    public static class GenericListHelpers
    {
        public static void GoThrough<T>(List<T>list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static void SaySomething(string something)
        {
            Console.WriteLine(something);
        }

        public static void GetInfo<T>(List<T>list)
        {
            T item = list[0];
            Console.WriteLine($"The list has {list.Count} items of type {item.GetType().Name}");
        }
    }
}
