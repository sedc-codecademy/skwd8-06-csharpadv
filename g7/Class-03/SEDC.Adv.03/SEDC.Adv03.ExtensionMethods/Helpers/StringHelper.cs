using System.Collections.Generic;
using System.Linq;

// We changed the namespace to System so now everywhere where there is a reference to System, this code can be executed
namespace System
{
	// Extension methods MUST ALWAYS EXIST IN A STATIC CLASS
	// Extension methods MUST ALWAYS BE STATIC
	// Extension methods MUST ALWAYS HAVE this KEYWORD BEFORE THE FIRST PARAMETER 
	public static class StringHelper
	{
		// We don't pass the first parameter the conventional way in the ()
		// The first parameter is filled with the balue of the item we call the extension method on
		// CORRECT: string name = "bob"; name.Shorten(5);
		// ^ - "bob" gets passed on to the first parameter, 5 gets passed on to the second
		// NOTE: In case where we have only the first parameter, we don't write anything in the ()
		// NOT CORRECT: string name = "bob"; Shorten(name, 5); 
		// Not correct since it is called as a standard method instead of an extension method

		// this points to the entity on which the method is called
		// This method should shorten a string by a given number of words
		// Ex: "Hello there bob".Shorten(1) -> result -> Hello
		public static string Shorten(this string str, int numberOfWords)
		{
			if (numberOfWords < 0) throw new Exception("number of words should be a positive number");
			if (str.Trim().Length == 0) return "";

			// We got a result as string[] but we converted it to List<string> with the ToList() ( from LINQ )
			List<string> words = str.Split(' ').ToList();

			if (words.Count < numberOfWords) return str;

			// ["bob" , "jill", "greg"].Take(2) -> ["bob" , "jill"]
			List<string> substring = words.Take(numberOfWords).ToList();

			// Join combines multiple items in to one string
			// The first parameter is the searator string which will be added between all the items
			string result = string.Join(" ", substring);

			return result + "...";
		}

		public static string QuoteString(this string text)
		{
			return '"' + text + '"';
		}
	}
}
