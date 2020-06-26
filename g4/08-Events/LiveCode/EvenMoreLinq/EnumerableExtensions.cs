using System;
using System.Collections.Generic;
using System.Text;

namespace EvenMoreLinq
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<TSource> WhereMax<TSource>(this IEnumerable<TSource> source, Func<TSource, int> selector)
        {
            return null;
        }
    }
}
