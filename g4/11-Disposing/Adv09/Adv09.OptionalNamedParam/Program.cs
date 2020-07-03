using System;
using System.Net.Mail;

namespace Adv09.OptionalNamedParam
{
	class Program
	{
		static void CheckOperation(int num1, int num2, string operation)
		{
			switch (operation)
			{
				case "+":
					Console.WriteLine($"{num1} {operation} {num2} = {num1 + num2}");
					break;
				case "-":
					Console.WriteLine($"{num1} {operation} {num2} = {num1 - num2}");
					break;
				default:
					Console.WriteLine($"The app does not work with {operation}!");
					break;
			}
		}
		static void NoOptional(int num1, int num2, string operation)
		{
			CheckOperation(num1, num2, operation);
		}

		static void SomeOptional(int num1, int num2, string operation = "+")
		{
			CheckOperation(num1, num2, operation);
		}

		static void AllOptional(int num1 = 5, int num2 = 10, string operation = "+")
		{
			CheckOperation(num1, num2, operation);
		}

		static void Main(string[] args)
		{
			NoOptional(2, 3, "+");
			// NoOptional(2, 3); // Will not work since the last is not optional
			SomeOptional(2, 3);
			SomeOptional(5, 3, "-");
			AllOptional();
			AllOptional(1);
			AllOptional(1, 5);
			AllOptional(12, 5, "-");

			NoOptional(num2: 3, operation: "+", num1: 10);
			NoOptional(10, operation: "-", num2: 3); // We can leave some unnamed argumens as long as their order is correct
			// NoOptional(operation: "+", 2, 4); // We can only do random order if ALL arguments are named

			Console.ReadLine();
		}
	}
}
