using SEDC.Adv.TryBeingFit.Domain;
using SEDC.Adv.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services
{
	public class UiService : IUiService
	{
		public int ChooseMenu<T>(List<T> items)
		{
			while (true)
			{
				Console.Clear();
				Console.WriteLine("Enter a number to choose one of the following:");
				for (int i = 0; i < items.Count; i++)
				{
					Console.WriteLine($"{i + 1}) {items[i]}");
				}
				// Choice of the user
				// The input needs to be a number
				// It needs to be in a particular range ( from 1 to the number of items of the collection items )
				int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), items.Count);
				if(choice == -1)
				{
					MessageHelper.PrintMessage("[Error] Input incorrect. Please try again.", ConsoleColor.Red);
					continue;
				}
				return choice;

			}
		}

		public int LogInMenu()
		{
			List<string> menuItems = new List<string>() { "Log In", "Regsiter" };
			return ChooseMenu(menuItems);

		}

		public int RoleMenu()
		{
			// Here we add all the options from the UserRole enum to a list
			// We do that by Enum.GetNames() method which will return an array of all the names of a particualr eunm
			// We give the type of the enum as a parameter so it knows which enum it is ( In our case UserRole )
			// We convert the array to list because we don't want to work with arrays
			List<string> menuItems = Enum.GetNames(typeof(UserRole)).ToList();
			return ChooseMenu(menuItems);
		}
	}
}
