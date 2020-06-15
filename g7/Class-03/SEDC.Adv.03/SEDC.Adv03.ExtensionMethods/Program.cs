using System;
using System.Collections.Generic;

namespace SEDC.Adv03.ExtensionMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			string text = "C# Advanced is an easy subject with great demos and activities!";

			#region String Helper Example
			// Shorten is called on text so text is the first parameter and 6 the second
			// QuoteString is called on the result of Shorten(6) which is a string, and has no parameters since
			// the result of Shorten(6) is the first parameter
			string shortened = text.Shorten(6).QuoteString();
			Console.WriteLine(shortened);
			Console.ReadLine();
			#endregion
			#region List Helper Example
			List<string> strings = new List<string>() { "str1", "str2", "str3" };
			List<int> ints = new List<int>() { 5, 22, -18 };
			List<bool> bools = new List<bool> { true, false, true };

			// Evolution of this GoThrough methods
			// ----------------------------------------------------------------------------
			// 1.1.  GoThrougStrings(List<string> strings); -> Call -> ListHelper.GoThroughStrings(strings)
			// 1.2   GoThrougInts(List<int> ints) -> Call -> ListHelper.GoThroughInts(ints)
			// ----------------------------------------------------------------------------
			// 2.1   GoThrough<T>(List<T> items) -> Call -> ListHelper.GoThrough(strings/ints/bools...)
			// ----------------------------------------------------------------------------
			// 3.1   GoThrough<T>(this List<T> items) -> Call -> strings.GoThrough()
			// ----------------------------------------------------------------------------
			strings.GoThrough();
			strings.GetInfo();

			ints.GoThrough();
			ints.GetInfo();

			bools.GoThrough();
			bools.GetInfo();
			#endregion
		}
	}
}
