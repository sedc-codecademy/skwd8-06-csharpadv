using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class03.ExtensionMethods
{
    public static class ListHelper
    {
        /// <summary>
        /// A Generic extension method that can be called on any list with items and print the list
        /// </summary>
        public static void GoThrough<T>(this List<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
        /// <summary>
        /// A Generic extension method that can be called on any list with items and get info 
        /// </summary>
        public static void GetInfo<T>(this List<T> items)
        {
            T first = items[0];
            Console.WriteLine($"This list has {items.Count} members and is of type {items.GetType().FullName}!");
        }
    }
}
