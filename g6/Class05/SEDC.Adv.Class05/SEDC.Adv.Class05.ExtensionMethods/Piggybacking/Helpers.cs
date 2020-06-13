using System;
using System.Collections.Generic;
using System.Text;

// namespace SEDC.Adv.Class05.ExtensionMethods.Piggybacking
// namespace System //piggy backed in System
namespace SEDC.Adv.Class05.ExtensionMethods.Helpers //piggy backed in SEDC.Adv.Class05.ExtensionMethods.Helpers
{
    public static class Helpers
    {
        public static string QuoteStringPiggybacking(this string text)
        {
            return '"' + text + '"';
        }

        public static List<T> GetInfoPiggybacking<T>(this List<T> list)
        {
            T first = list[0];
            Console.WriteLine($"This list has {list.Count} members of type {first.GetType().Name}");
            return list;
        }
    }
}
