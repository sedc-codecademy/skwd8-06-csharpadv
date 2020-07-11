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
		public List<string> MainMenuItems { get; set; }
		public List<string> AccountMenuItems { get; set; }
		// Generic method that generates dynamically menus
		// It only needs a list of menu items ( any primitive type will do ) and it will:
		// 1. Generate the menu
		// 2. Ask for an input
		// 3. Validate the input
		// 4. Return the value of the user choice
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
		// This generates a log in or register menu and gets the answer from the user
		public int LogInMenu()
		{
			// We create all the menu options in a list
			// Then we call a method that generates a menu from a list of items automatically
			// That method also requests for the user input and validates their input as well
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

		// #Added
		public int MainMenu(UserRole role)
		{
			MainMenuItems = new List<string>() { "Account", "Log Out" };
			switch (role)
			{
				case UserRole.Standard:
					MainMenuItems.Insert(0, "Train");
					MainMenuItems.Insert(0, "Upgrade to Premium");
					break;
				case UserRole.Premium:
					MainMenuItems.Insert(0, "Train");
					break;
				case UserRole.Trainer:
					MainMenuItems.Insert(0, "Reschedule training");
					break;
			}
			return ChooseMenu(MainMenuItems);
		}
		public int AccountMenu(UserRole role)
		{
			AccountMenuItems = new List<string>() { "Change Info", "Check Subscription", "Change Password" };
			return ChooseMenu(AccountMenuItems);
		}
		public void UpgradeToPremium()
		{
			Console.Clear();
			Console.WriteLine("Upgrade to premium to get these features:");
			Console.WriteLine("* Live trainings");
			Console.WriteLine("* Newsletter in your mail");
			Console.WriteLine("* Discounts at sports equipment stores");
			Console.ReadLine();
		}
		public int TrainMenu()
		{
			Console.Clear();
			List<string> trainingMenu = new List<string>() { "Video", "Live" };
			Console.WriteLine("Choose what type of training do you want:");
			return ChooseMenu(trainingMenu);
		}
		// This method is a generic method for ANY type of training
		// That means that it will work for generating a menu for Live or Video trainings
		// It can even work with new future types of trainings
		public int TrainMenuItems<T>(List<T> trainings) where T : Training
		{
			Console.Clear();
			Console.WriteLine("Choose a training:");
			return ChooseEntiiesMenu(trainings);

		}

		// This is the same function as ChooseMenu but it works with Complex Types ( objects like VideoTraining, LiveTraining, StandardUser etc... )
		// ChooseMenu only works with primitive values ( int, string, bool )
		// We can't use any class. We must use the classes that are connected to our business logic ( All that inherit from BaseEntity )
		public int ChooseEntiiesMenu<T>(List<T> entities) where T : IBaseEntity
		{
			Console.Clear();
			while (true)
			{
				Console.WriteLine("Enter a number to choose one of the following:");
				for (int i = 0; i < entities.Count; i++)
				{
					Console.WriteLine($"{i + 1}) {entities[i].Info()}");
				}
				int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), entities.Count);
				if (choice == -1)
				{
					MessageHelper.PrintMessage("[Error] Input incorrect. Please try again", ConsoleColor.Red);
					Console.ReadLine();
					continue;
				}
				return choice;
			}
		}

		public void Welcome(User user)
		{
			Console.Clear();
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
			Console.ReadLine();
		}
	}
}
