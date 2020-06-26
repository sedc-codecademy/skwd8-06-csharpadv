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
		public int ChooseEntiiesMenu<T>(List<T> entities) where T : IBaseEntity
		{
			throw new NotImplementedException();
		}

		public int ChooseMenu<T>(List<T> items)
		{
			Console.Clear();
			while (true)
			{
				Console.WriteLine("Enter a number to choose one of the following: ");
				for (int i = 0; i < items.Count; i++)
				{
					Console.WriteLine($"{i +1} - {items[i]}");
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

		public int LogInMenu()
		{
			throw new NotImplementedException();
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

		public int RoleMenu()
		{
			throw new NotImplementedException();
		}

		public void Welcome(User user)
		{
			throw new NotImplementedException();
		}
	}
}
