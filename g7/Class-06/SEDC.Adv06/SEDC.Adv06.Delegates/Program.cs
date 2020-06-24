using System;

namespace SEDC.Adv06.Delegates
{
	class Program
	{
		public static void SayHello(string person)
		{
			Console.WriteLine($"Hello {person}!");
		}

		public static void SayBye(string prs)
		{
			Console.WriteLine($"Bye {prs}!");
		}
		// Our own higher order method in C#
		// It only accepts methods that follow the rules of SayDelegate
		// It can be ANY method as long as it follows thoes rules
		public static void SayWhatever(string something, SayDelegate method)
		{
			Console.WriteLine("The program says:");
			method(something); // We are calling the delegate as if it were a normal method
		}
		// This is a delegate
		// It will accept all methods with void return type and 1 parameter that is string
		// The name of the parameter and the name of the method can be differnet
		public delegate void SayDelegate(string something);
		static void Main(string[] args)
		{
			#region Instantiating a delegate with methods
			// SayDelegate is like a type for methods
			Console.WriteLine("----------------Standard delegate calls---------------");
			SayDelegate hello = new SayDelegate(SayHello);
			SayDelegate bye = new SayDelegate(SayBye);
			SayDelegate wow = new SayDelegate(x => Console.WriteLine($"WOW {x}!"));
			//SayDelegate broken = new SayDelegate((x, y) => Console.WriteLine($"{x} and {y}")); // This will not work since there are 2 parameters instead of 1

			hello("Bob");
			bye("Bob");
			wow("Bob");
			#endregion
			#region Passing a method to a delegate parameter ( Higher order method )
			Console.WriteLine("----------------Higher order method calls---------------");
			SayWhatever("Bob", SayHello);
			SayWhatever("Bob", SayBye);
			SayWhatever("Bob", x => Console.WriteLine($"WOW {x}!"));
			SayWhatever("Bob", x =>
			{
				Console.WriteLine($"This is {x}!");
				Console.WriteLine("They are cool!");
			});

			#endregion

			Console.ReadLine();
		}
	}
}
