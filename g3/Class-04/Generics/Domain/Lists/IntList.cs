using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    // NOTE: The logic of this class is exactly the same as StringList, only the types are different, so a problem of this nature is easily resolved by using Generics
    // NOTE: See the AnyList class for Generics implementation
    // A simple class that should represent a collection of data of type "int".
    // Check the comments from StringsList class since the logic is identical.
    public class IntList
    {
        private int[] _ints;

        public IntList()
        {
            _ints = new int[0];
            Count = 0;
        }

        public int Count { get; set; }

        public int Add(int item)
        {
            int newSize = _ints.Length + 1;

            Array.Resize(ref _ints, newSize);
            _ints[newSize - 1] = item;

            Count++; // "Count = newSize;" is more appropriate
            return newSize;
        }

        public void Print()
        {
            foreach (int item in _ints)
            {
                Console.WriteLine(item);
            }
        }
    }
}
