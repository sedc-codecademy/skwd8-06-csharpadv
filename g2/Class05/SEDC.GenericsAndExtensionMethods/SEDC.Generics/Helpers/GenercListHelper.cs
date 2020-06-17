using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Generics.Helpers
{
    public class GenercListHelper
    {

        public void GoThrough<T>(List<T> items)
        {
            items.ForEach(x => Console.WriteLine(x));
        }

        public void GetInfo<T>(List<T> items)
        {
            T first = items[0];
            Console.WriteLine($"This list has {items.Count} items and is of type {first.GetType().Name}!");
        }
    }
}
