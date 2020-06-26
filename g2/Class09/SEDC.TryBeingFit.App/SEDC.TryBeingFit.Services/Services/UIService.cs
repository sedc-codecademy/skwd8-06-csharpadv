using SEDC.TryBeingFit.Domain;
using SEDC.TryBeingFit.Domain.Core.Enums;
using SEDC.TryBeingFit.Domain.Core.Interfaces;
using SEDC.TryBeingFit.Domain.Core.Models;
using SEDC.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services
{
    public class UIService : IUIService
    {
        public List<string> AccountMenuItems { get; set; }
        public List<string> MainMenuItems { get; set; }

        public int AccountMenu(UserRole role)
        {
            AccountMenuItems = new List<string>() { "Change Info", "Check Subscription", "Change Password" };
            return ChooseMenu(AccountMenuItems);
        }

        public int ChooseMenu<T>(List<T> items)
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Enter a number to choose one of the following:");
                for(int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{ i + 1 }) {items[i]}");
                }
                int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), items.Count);
                if(choice == -1)
                {
                    MessageHelper.Color("[Error] Input incorrect. Please try again!", ConsoleColor.Red);
                    Console.ReadLine();
                    continue;
                }
                return choice;
            }
        }

        public int MainMenu(UserRole role)
        {
            MainMenuItems = new List<string>() { "Account", "Log out" };
            switch (role)
            {
                case UserRole.Standard:
                    MainMenuItems.Insert(0, "Train");
                    MainMenuItems.Insert(0, "Upgrade to premium");
                    break;
                case UserRole.Premium:
                    MainMenuItems.Insert(0, "Train");
                    break;
                case UserRole.Trainer:
                    MainMenuItems.Insert(0, "Reschedule training");
                    MainMenuItems.Insert(0, "Train");
                    break;
                default:
                    break;
            }
            return ChooseMenu(MainMenuItems);
        }

        public int LogIn()
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

        public int ChooseEntitiesMenu<T>(List<T> entities) where T : IBaseEntity
        {
            throw new NotImplementedException();
        }

        public int TrainMenu()
        {
            throw new NotImplementedException();
        }

        public int TrainMenuItems<T>(List<T> items) where T : Training
        {
            throw new NotImplementedException();
        }

        public void UpgradeToPremium()
        {
            throw new NotImplementedException();
        }

        public void Welcome(User user)
        {
            throw new NotImplementedException();
        }
    }
}
