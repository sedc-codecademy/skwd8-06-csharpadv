using SEDC.Exercise.TryBeingFit.Domain;
using SEDC.Exercise.TryBeingFit.Domain.Core.Entities;
using SEDC.Exercise.TryBeingFit.Domain.Core.Enums;
using SEDC.Exercise.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Exercise.TryBeingFit.Services.Services
{
    public class UIService
    {
        public List<string> MainMenuItems { get; set; }
        public List<string> AccountMenuItems { get; set; }

        public int LogInMenu()
        {
            MainMenuItems = new List<string>() { "LogIn", "Register" };
            return ChooseMenu(MainMenuItems);

        }

        public int RoleMenu()
        {
            MainMenuItems = Enum.GetNames(typeof(UserRole)).ToList();
            return ChooseMenu(MainMenuItems);

        }

        public int ChooseMenu<T>(List<T> items)
        {
            while(true)
            {
                Console.WriteLine("Enter a number to choose one of the following: ");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"({i + 1}) {items[i]}");
                }
                int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), items.Count);
                if(choice == -1)
                {
                    // ("Input incorect. Please try again", color)
                    // continue;
                }

                return choice;
            }
        }

        public void Welcome(User user)
        {
            Console.WriteLine($"Welcome to the fitness application user:  {user.Username}");
            switch (user.Role)
            {
                case UserRole.Standard:
                    Console.WriteLine($"If you enjoy the application, consider our Premium subscription..");
                    break;
                case UserRole.Premium:
                    Console.WriteLine($"");
                    break;
                case UserRole.Trainer:
                    Console.WriteLine($"");
                    break;
                
            }

        }

        public int MainMenu(UserRole role)
        {
            MainMenuItems = new List<string>() { "Account", "Log Out" };
            switch (role)
            {
                case UserRole.Standard:
                    MainMenuItems.Insert(0, "Train");
                    MainMenuItems.Insert(1, "Upgrade to Premium");
                    break;
                case UserRole.Premium:
                    MainMenuItems.Insert(0, "Train");
                    break;
                case UserRole.Trainer:
                    MainMenuItems.Insert(0, "Reschedule Training");
                    break;

            }

            return ChooseMenu(MainMenuItems);
        }

        public int TrainMenuItems<T>(List<T> trainings) where T : Training
        {
            Console.Clear();
            Console.WriteLine("Choose a training:");
            return ChooseEntitiesMenu(trainings);
        }

        public int ChooseEntitiesMenu<T>(List<T> entitites) where T : BaseEntity
        {
            Console.Clear();
            while(true)
            {
                Console.WriteLine("Enter a number to choose one of the following: ");
                for (int i = 0; i < entitites.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {entitites[i].Print()}");
                }
                int choice = ValidationHelper.ValidateNumber(Console.ReadLine(), entitites.Count);
                if(choice == -1)
                {
                    MessageHelper.Color("[Error] Input incorrect. Please try again..", ConsoleColor.Red);
                    Console.ReadLine();
                    continue;
                }
                return choice;
            }
        }

        public int TrainMenu()
        {
            Console.Clear();
            List<string> trainingMenu = new List<string>() { "Video", "Live" };
            Console.WriteLine("Choose what type of trainiing do you want ?");
            return ChooseMenu(trainingMenu);

        }

        //public int AccountMenu()
        //{

        //}

 
    }
}
