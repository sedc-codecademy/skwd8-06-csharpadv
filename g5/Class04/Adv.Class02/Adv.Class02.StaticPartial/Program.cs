using Adv.Class03.StaticPartial.Entities;
using System;

namespace Adv.Class03.StaticPartial
{
	class Program
	{
		
		static void Main(string[] args)
		{
			while (true)
			{
				#region User Interface

				#region Main Menu

				Console.Clear();
				User _currentUser = new User();
				Console.WriteLine("Welcome to the ordering menu!");
				if(TextHelper.MessagesGenerated != 0) Console.WriteLine(
					$"Fun fact: People checked their order status {TextHelper.MessagesGenerated} times!");
				Console.WriteLine("Choose a User:");
				OrdersTempDB.ListUsers();
				int userChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
				if (userChoice == -1) continue;
				_currentUser = OrdersTempDB.Users[userChoice - 1];
				#endregion

				#region Orders Menu
				Console.Clear();
				Console.WriteLine("Orders menu");
				Console.WriteLine("1) Check Orders");
				Console.WriteLine("2) Add new Order");
				int menuChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
				if (menuChoice == -1) continue;
				if (menuChoice == 1)
				{
					Console.Clear();
					Console.WriteLine("Choose one to check the status:");
					_currentUser.PrintOrders();
					int orderChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
					if (menuChoice == -1) continue;
					TextHelper.GenerateStatusMessage(_currentUser.Orders[orderChoice - 1].Status);
					Console.ReadLine();
				}
				else if (menuChoice == 2)
				{
					Console.Clear();
					Order newOrder = new Order();
					Console.WriteLine("Enter order name:");
					newOrder.Title = Console.ReadLine();
					Console.WriteLine("Enter order description:");
					newOrder.Description = Console.ReadLine();
					OrdersTempDB.InsertOrder(_currentUser.Id, newOrder);
					Console.ReadLine();
				}
				#endregion

				#endregion
			}

		}
	}
}
