using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TryBeingFit.Domain.Core.Entities;
using TryBeingFit.Domain.Core.Enums;
using TryBeingFit.Services.Helpers;

namespace TryBeingFit.Services.Services
{
    public class UIService : IUIInterface
    {
		//Loads the main menu depending on the role of the user
		public int MainMenu(UserRole role)
		{
			List<string> menuItems = new List<string>() { "Account", "Log Out" };
			switch (role)
			{
				case UserRole.Standard:
					menuItems.Insert(0, "Train");
					menuItems.Insert(0, "Upgrade to Premium");
					break;
				case UserRole.Premium:
					menuItems.Insert(0, "Train");
					break;
				case UserRole.Trainer:
					menuItems.Insert(0, "Reschedule training");
					break;
			}
			return ChooseMenu(menuItems);
		}
		//Loads the account menu depending on the role of the user
		public int AccountMenu(UserRole role)
		{
			List<string> menuItems = new List<string>() { "Change Info", "Check Subscription", "Change Password" };
			if (role != UserRole.Trainer) menuItems.Add("Change Trainings");
			return ChooseMenu(menuItems);
		}
		//Loads a menu with print message from every entity in the list and asks the user to input a choice.
		//After validating it, the choice is returned
		public int ChooseEntitiesMenu<T>(List<T> entities) where T : IBaseEntity
		{
			while (true)
			{
				Console.WriteLine("Enter a number to choose one of the following:");
				for (int i = 0; i < entities.Count; i++)
				{
					Console.WriteLine($"{i + 1}) {entities[i].Print()}");
				}
				int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), entities.Count);
				if (choice == -1)
				{
					MessageHelper.Color("[Error] Input incorrect. Please try again", ConsoleColor.Red);
					Console.ReadLine();
					continue;
				}
				return choice;
			}
		}
		//Gets a list of generic T items and asks the user to choose an option from the list
		// The chosen option is being validated before returning and if not a valid number is typed, the procedure is repeated
		public int ChooseMenu<T>(List<T> items)
		{
			while (true)
			{
				Console.WriteLine("Enter a number to choose one of the following:");
				for (int i = 0; i < items.Count; i++)
				{
					Console.WriteLine($"{i + 1}) {items[i]}");
				}
				int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), items.Count);
				if (choice == -1)
				{
					MessageHelper.Color("[Error] Input incorrect. Please try again", ConsoleColor.Red);
					Console.ReadLine();
					continue;
				}
				return choice;
			}
		}
		//Loads the welcome message depending on the role of the user
		public void Welcome(User user)
		{
			Console.WriteLine($"Welcome to the fitness app {user.Username}!");
			switch (user.Role)
			{
				case UserRole.Standard:
					Console.WriteLine("If you enjoy the app, consider our Premium subscription!");
					break;
				case UserRole.Premium:
					Console.WriteLine("We are so glad you are part of our community!");
					break;
				case UserRole.Trainer:
					Console.WriteLine("We are so glad to have you as a partner!");
					break;
			}
		}
		//Loads the login menu and returns the user choice of the menu by using the method ChooseMenu
		public int LogInMenu()
		{
			List<string> menuItems = new List<string>() { "LogIn", "Register" };
			return ChooseMenu(menuItems);
		}
		//Loads the roles menu and returns the user choice of the menu by using the method ChooseMenu
		public int RoleMenu()
		{
			List<string> menuItems = Enum.GetNames(typeof(UserRole)).ToList();
			return ChooseMenu(menuItems);
		}
	}
}
