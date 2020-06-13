using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._03Generics.Helpers
{
	public static class GenericListHelper
	{
		// <T> after the name -> We are telling this method that it is going to be generic
		// And it is going to use the T placeholder as placeholder type for the whole method
		// After that we can use T in the parameters as well as the block of code ( inside { } )
		// We are using T type in the List as parameter
		// T is not a rule, it is a convention -> Meaning you can use whatever
		// But it is not a good practise to use whatever you want

		// This method will replace all 3 GoThroug methods of the not generic helper
		// AND it can work even for other types as well ( like char, decimal, float etc. )
		public static void GoThrough<T>(List<T> items)
		{
			foreach (T item in items)
			{
				Console.WriteLine(item);
			}
		}

		public static void GetInfo<T>(List<T> items)
		{
			// This variable is of type T
			// This means that when T is replaced with string, this will become string first = items[0];
			// If T is replaced with int, this will become int first = items[0];
			T first = items[0];
			Console.WriteLine($"This list has {items.Count} members and the are of type {first.GetType().Name}");
		}
	}
}
