using SEDC.Adv09.LoggerExample.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SEDC.Adv09.LoggerExample
{
	// USE CASE:
	// We need to handle the errors in our application that has a log in screen
	// We needed to handle people failing to log in separately ( when a person does not succeed to log in )
	// We needed to handle people entering wrong information about a property separately as well
	// All the issues, the login, the wrong property as well as any other issue in the app should be logged in a text file
	// This text file will help the QA or Operations team to figure out what's wrong
	// We also want to track how much errors did we register globaly at any time

	class Program
	{
		static LoggerService _logger = new LoggerService();
		static List<User> _users = new List<User>()
		{
			new User(){Username = "Bob20", Password = "123456", Age = 20, Id = 4 },
			new User(){Username = "JillCool", Password = "coolcat", Age = 34, Id = 12 },
			new User(){Username = "Gregonator", Password = "astalavista", Age = 44, Id = 76 }
		};

		static void Login(string username, string password)
		{
			User user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);
			if (user == null) throw new InvalidLoginException(username);
			Console.WriteLine($"Welcome {username}");
		}
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Welcome to the amazing app:");
				Console.WriteLine("Enter username:");
				string username = Console.ReadLine();
				Console.WriteLine("Enter password:");
				string password = Console.ReadLine();
				Login(username, password);

				// UNEXPECTED ERRORS - Uncomment them one at a time to try them out 

				// What happens if an invalid property of a user is added
				// User newUser = new User() { Id = 33, Username = "JoeJoe", Password = "joebest", Age = -11 };

				// What happens if some random error occurs
				// int invalidNum = int.Parse("Bob");

				Console.ReadLine();
			}
			catch (InvalidLoginException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("Check your username and password again!");
				_logger.Log("Invalid Login", ex.Message, ex.Username);
			}
			catch (InvalidUserPropertyException ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("Check the values for properties and try again!");
				_logger.Log("InvalidUserProperty", ex.Message, ex.User);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine("An unexpected error occured! Please contact support on : +389 932 432 5325!");
				_logger.Log(ex.GetType().Name, ex.Message);
				_logger.UpdateErrorCount();
			}

			Console.ReadLine();
		}
	}
}
