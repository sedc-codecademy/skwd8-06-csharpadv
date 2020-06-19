using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace OddsSods
{
    public static class SedcLinq
    {
        //public static List<U> Select<T, U>(this List<T> source, Func<T, U> selectorFunction)
        //{
        //    var result = new List<U>();
        //    foreach (var item in source)
        //    {
        //        var processed = selectorFunction(item);
        //        result.Add(processed);
        //    }
        //    return result;
        //}

        //public static List<T> Where<T>(this List<T> source, Func<T, bool> predicateFunction)
        //{
        //    var result = new List<T>();
        //    foreach (var item in source)
        //    {
        //        if (predicateFunction(item))
        //        {
        //            result.Add(item);
        //        }
        //    }
        //    return result;
        //}

        public static IEnumerable<U> Select<T, U>(this IEnumerable<T> source, Func<T, U> selectorFunction)
        {
            foreach (var item in source)
            {
                var processed = selectorFunction(item);
                yield return processed;
            }
        }

        public static IEnumerable<T> Where<T>(this IEnumerable<T> source, Func<T, bool> predicateFunction)
        {
            foreach (var item in source)
            {
                if (predicateFunction(item))
                {
                    yield return item;
                }
            }
        }



        public static void Print<T>(this IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }

    }
}
