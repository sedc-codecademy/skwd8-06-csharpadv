using System;
using System.Collections.Generic;

namespace SEDC.Anonymous.Extensions
{
    public static class ListExtensions
    {
        public static string FindOrDefault(this List<string> list, Func<string, bool> callback)
        {
            string result = null;

            foreach (var item in list)
            {
                var isItemFound = callback(item);

                if (isItemFound)
                {
                    result = item;
                    break;
                }
            }

            return result;
        }
    }
}
