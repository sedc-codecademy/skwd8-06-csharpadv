using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class05.ExtensionMethods.Helpers
{
    public static class ListHelpers
    {
        public static void GoThrough<T>(this List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public static List<T> GetInfo<T>(this List<T> list)
        {
            T first = list[0];
            Console.WriteLine($"This list has {list.Count} members of type {first.GetType().Name}");
            return list;
        } 
    }
}
