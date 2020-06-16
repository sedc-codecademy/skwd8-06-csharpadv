using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Domain
{
    // A simple class that should represent a collection of data of type "string"
    public class StringList
    {
        private string[] _strings; // This is where all the string values are kept in the background of this class. NOTE: This property is not a property, but it's a field, we can tell by seeing that it lacks the get and set methods

        public StringList()
        {
            _strings = new string[0];
            Count = 0;
        }

        public int Count { get; set; } // This is equivalent of the Count property from List class

        public int Add(string item)
        {
            int newSize = _strings.Length + 1;

            Array.Resize(ref _strings, newSize);
            _strings[newSize - 1] = item;

            Count++; // "Count = newSize;" is more appropriate
            return newSize;
        }

        public void Print()
        {
            foreach (string item in _strings)
            {
                Console.WriteLine(item);
            }
        }
    }
}
