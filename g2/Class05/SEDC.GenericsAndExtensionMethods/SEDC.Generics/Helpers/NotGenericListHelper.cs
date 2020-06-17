﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Generics.Helpers
{
    /// <summary>
	/// Normal non generic class
	/// </summary>
    public class NotGenericListHelper
    {
        /// <summary>
        /// Function, as a paramter takes list of strings, 
        /// we are just iterating through the list and
        /// printing the output on the console.
        /// </summary>
        public void GoThroughStrings(List<string> strings)
        {
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
        }

        public void GetInfoForStrings(List<string> strings)
        {
            string first = strings[0];
            Console.WriteLine($"This list has {strings.Count} items and is of type {first.GetType().Name}!");
        }

        public void GoThroughInts(List<int> ints)
        {
            foreach (var num in ints)
            {
                Console.WriteLine(num);
            }
        }

        public void GetInfoForInts(List<int> ints)
        {
            int first = ints[0];
            Console.WriteLine($"This list has {ints.Count} items and is of type {first.GetType().Name}!");
        }

    }
}
