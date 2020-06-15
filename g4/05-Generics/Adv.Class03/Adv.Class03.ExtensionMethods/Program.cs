using System;
using System.Collections.Generic;

namespace Adv.Class03.ExtensionMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			#region String Extension Methods
			// Long string for an example. 
			string text = "C# Advanced is an awesome subject with great demos and activities!";

			// Here we are calling the extension method Shorten on the text string and saying
			// that we want to take the first 6 words from it and QuouteString() method
			// just wraps that string in quotes.
			string shortDescription = text.Shorten(6).QuoteString();
			Console.WriteLine(shortDescription);

			Console.ReadLine();
			#endregion
			#region Generic Extension Method
			List<string> strings = new List<string>() { "str1", "str2", "str3" };
			List<int> ints = new List<int>() { 5, 22, -18 };
			List<bool> bools = new List<bool> { true, false, true };

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
