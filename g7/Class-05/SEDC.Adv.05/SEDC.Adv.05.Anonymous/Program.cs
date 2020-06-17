using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Adv._05.Anonymous
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> names = new List<string>()
			{
				"Bob", "Jill", "Wayne", "Greg", "John", "Anne"
			};
			List<string> nonames = new List<string>();

			#region Func
			// bool -> return type ( return == bool )
			// The result of the anonymous function is also bool
			// Lambda expressions work very similar to JS
			// When we have no parameters, we write () brackets and then =>
			// When we have 1 expression in the anonymous method, we don't need return or { }
			// EXAMPLE with no parameters
			Func<bool> isNamesEmpty = () => names.Count == 0;
			// Func<bool> broken1 = () => names[0]; // Broken -> Because the return type does not match
			Console.WriteLine($"IsNamesEmpty: {isNamesEmpty()}");

			// EXAMPLE with 1 parameter
			// List<string> -> first parameter ( x == List<string> )
			// bool -> return type ( return == bool )
			Func<List<string>, bool> isListEmpty = x => x.Count == 0;
			bool resultFromIsListEmpty = isListEmpty(nonames);
			// bool brokenResult = isListEmpty(new List<int>()); // Broken -> We request for a paramerer List<string> but we give it List<int>
			Console.WriteLine($"IsListEmpty: {resultFromIsListEmpty}");

			// EXAMPLE with 2 parameters
			// int -> first parameter ( x == int )
			// int -> second parameter ( y == int )
			// string -> return type ( return == string )
			Func<int, int, string> sum = (x, y) => $"The result is: {x + y}!";
			string resultFromSum = sum(1, 5);
			// string brokenSumResult = Sum("1", 5); // Broken -> We request for an int in the first parameter but we get a string
			Console.WriteLine(resultFromSum);

			// We must use brackets for multiple lines of code ( multiple expressions )
			// We must use the keyword return since we have a block of code and C# can't determine which line it needs to return
			// int -> first parameter ( x == int )
			// int -> second parameter ( y == int )
			// bool -> return type ( return == bool )
			Func<int, int, bool> checkLarger = (x, y) =>
			{
				if (x > y) return true;
				return false;
			};
			Console.WriteLine($"Is 5 larger than 3: {checkLarger(5, 3)}");
			#endregion
			#region Action
			// ACTION represents a void method
			// If there are no parameters we don't write the < >
			// EXAMPLE with no parameters
			Action hello = () => Console.WriteLine("Hello there!");
			hello();

			// EXAMPLE with 1 parameter
			// string -> first parameter ( x == string )
			Action<string> printError = x =>
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(x);
				Console.ResetColor();
			};
			printError("Error. Please try again!");

			// EXAMPLE with 2 parameters
			// string -> first parameter ( x == string )
			// ConsoleColor -> second parameter ( y == ConsoleColor )
			Action<string, ConsoleColor> printColorMessage = (x, y) =>
			{
				Console.ForegroundColor = y;
				Console.WriteLine(x);
				Console.ResetColor();
				// return true; // Broken -> Because Action is always a void method
			};

			printColorMessage("Oops.. It was not an error. Sorry. Carry on!", ConsoleColor.Cyan);
			#endregion
			#region Higher order functions use
			// Find Bob
			// Regular way of calling LINQ method
			string bob1 = names.FirstOrDefault(x => x == "Bob");
			Console.WriteLine($"Bob found with lambda expression: {bob1}");

			// Bob finder app
			Func<string, bool> isBob = x => x == "Bob";
			string bob2 = names.FirstOrDefault(isBob);
			Console.WriteLine($"Bob found with Func method: {bob2}");

			// Person finder app
			Console.WriteLine("Enter a person name:");
			string name = Console.ReadLine();

			Func<string, bool> isPerson = x => x == name;
			string person = names.FirstOrDefault(isPerson);
			Console.WriteLine($"Person found with Func method: {person}");
			#endregion

			Console.ReadLine();
		}
	}
}
