using System;
using System.Collections.Generic;

namespace SEDC.Adv.Class11.NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            if(user.FullName == null)
            {
                // code ...
            }

            long emb = 0;
            if (user.EMB.HasValue)
            {
                emb = user.EMB.Value;
            }

            int? age = user.Age;
            Nullable<int> age1 = user.Age;

            int ageValue = user.Age.Value;

            // null coalescing

            long emb1 = 0;
            if (user.EMB.HasValue)
            {
                emb1 = user.EMB.Value;
            }

            long emb2 = user.EMB ?? 0;

            List<int?> listOfNullableIntegers = new List<int?>() { 1, 2, 3, null, null, 3, null, null };

            Console.ReadLine();
        }
    }
}
