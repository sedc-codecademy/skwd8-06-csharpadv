using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Interfacing
{
    class PersonByNameComparer : IComparer<Person>
    {
        public int Compare([AllowNull] Person x, [AllowNull] Person y)
        {
            Console.WriteLine("Called comparer compare");
            if (x == null) return -1;
            if (y == null) return 1;

            var fcompare = x.FirstName.CompareTo(y.FirstName);
            if (fcompare != 0) return fcompare;

            var lcompare = x.LastName.CompareTo(y.LastName);
            if (lcompare != 0) return lcompare;

            return x.Age.CompareTo(y.Age);
        }
    }
}
