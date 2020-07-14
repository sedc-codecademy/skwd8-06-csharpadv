using SEDC.Adv.TryBeingFit.Domain.Entities;
using SEDC.Adv.TryBeingFit.Domain.Enums;
using SEDC.Adv.TryBeingFit.Domain.Interfaces;
using SEDC.Adv.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.Services
{
	public class UIService : IUIService
	{
		public List<string> MainMenuItems { get; set; }
		public List<string> AccountMenuItems { get; set; }

		public int AccountMenu()
		{
			AccountMenuItems = new List<string>()
				{ "Change Info", "Check Subscription", "Change Password" };
			return ChooseMenu(AccountMenuItems);
		}

		public int ChooseEntitiesMenu<T>(List<T> entities) where T : IBaseEntity
		{
			Console.Clear();
			while(true)
			{
				Console.WriteLine("Enter a number to choose one of the following :");
				for (int i = 0; i < entities.Count; i++)
				{
					Console.WriteLine($"{i + 1} { entities[i].PrintInfo() }");
				}
				int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), entities.Count);
				if (choice == -1)
				{
					MessageHelper.Color("[ERROR] Incorrect input. Please try again.", ConsoleColor.Red);
					continue;
				}
				return choice;
			}
			
		}

		public int TrainMenuItems<T>(List<T> items) where T : Training
		{
			Console.Clear();
			Console.WriteLine("Choose a training : ");
			return ChooseEntitiesMenu(items);
		}


		public int LogInMenu()
		{
			Console.Clear();
			List<string> menuItems = new List<string>() { "LogIn", "Register" };
			return ChooseMenu(menuItems);
		}

		public int RoleMenu()
		{
			Console.Clear();
			List<string> menuItems = Enum.GetNames(typeof(UserRole)).ToList();
			return ChooseMenu(menuItems);
		}

		public int TrainMenu()
		{
			Console.Clear();
			List<string> trainingMenu = new List<string>() { "Live", "Video" };
			Console.WriteLine("Choose what type of training do you want");
			return ChooseMenu(trainingMenu);
		}


		public void UpgradeToPremium()
		{
			Console.Clear();
			Console.WriteLine("Upgrade to premium user get these features:");
			Console.WriteLine("* Live Trainings");
			Console.WriteLine("* Newsletter in your mail");
			Console.WriteLine("* Discounts at sports equipment stores");
			Console.ReadLine();
		}

		public void Welcome(User user)
		{
			Console.Clear();
			Console.WriteLine($"Welcome to the fitness app {user.Username}");
			switch (user.Role)
			{
				case UserRole.Standard:
					Console.WriteLine("If you enjoy the app, consider our Premium subscription!");
					break;
				case UserRole.Premium:
					Console.WriteLine("We are so glad you are part of our community");
					break;
				case UserRole.Trainer:
					Console.WriteLine("We are so glad to have you as a partner");
					break;
				default:
					Console.WriteLine("This shouldn't happen");
					throw new ApplicationException("User does not have role");
			}
			Console.ReadLine();
		}

		public int ChooseMenu<T>(List<T> items)
		{
			Console.Clear();
			while (true)
			{
				Console.WriteLine("Enter a number to choose one of the following: ");
				for (int i = 0; i < items.Count; i++)
				{
					Console.WriteLine($"{i + 1} - {items[i]}");
				}
				var userChoise = Console.ReadLine();
				var choice = ValidationHelper.ValidateNumber(userChoise, items.Count);
				if (choice == -1)
				{
					MessageHelper.Color("[Error] Incorrect input. Try again!", ConsoleColor.Red);
					continue;
				}
				return choice;

			}
		}

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
					MainMenuItems.Insert(0, "Reschedule traing");
					break;
				default:
					return -1;
			}
			return ChooseMenu(MainMenuItems);
		}

		
	}
}
