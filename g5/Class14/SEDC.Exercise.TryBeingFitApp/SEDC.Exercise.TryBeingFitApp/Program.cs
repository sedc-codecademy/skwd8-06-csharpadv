﻿using SEDC.Exercise.TryBeingFit.Domain;
using SEDC.Exercise.TryBeingFit.Domain.Core.Entities;
using SEDC.Exercise.TryBeingFit.Domain.Core.Enums;
using SEDC.Exercise.TryBeingFit.Services.Helpers;
using SEDC.Exercise.TryBeingFit.Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Exercise.TryBeingFitApp
{
    class Program
    {
        public static UIService _uiService = new UIService();
        public static UserService<StandardUser> _standardUserSrvc = new UserService<StandardUser>();
        public static UserService<PremiumUser> _premiumUserSrvc = new UserService<PremiumUser>();
        public static UserService<TrainerUser> _trainerUserSrvc = new UserService<TrainerUser>();
        public static TrainingService<VideoTraining> _videoTrainings = new TrainingService<VideoTraining>();
        public static TrainingService<LiveTraining> _liveTrainings = new TrainingService<LiveTraining>();
        public static User _currentUser;

        public static void Seed()
        {
            if (_standardUserSrvc.IsDbEmpty() && _premiumUserSrvc.IsDbEmpty() && _trainerUserSrvc.IsDbEmpty())
            {
                _standardUserSrvc.Register(new StandardUser() { FirstName = "Bob", LastName = "Bobsky", Username = "bobob1", Password = "bobbest1" });
                _premiumUserSrvc.Register(new PremiumUser() { FirstName = "Jill", LastName = "Wayne", Username = "jillw", Password = "jillsuper26" });
                TrainerUser John = new TrainerUser() { FirstName = "John", LastName = "Johnsky", Username = "johnjj", Password = "johny55" };
                _trainerUserSrvc.Register(John);
                _videoTrainings.AddTraining(new VideoTraining() { Title = "30 min workout", Description = "Cool workout for begginers and inermediate users", Difficulty = Difficulty.Medium, Link = "https://www.youtube.com/watch?v=50kH47ZztHs", Rating = 4, Time = 35 });
                _videoTrainings.AddTraining(new VideoTraining() { Title = "Standing Abs workout", Description = "Abs workout for people at home with no equipment", Difficulty = Difficulty.Easy, Link = "https://www.youtube.com/watch?v=Qia2ZXEzyLw", Rating = 5, Time = 11 });
                _videoTrainings.AddTraining(new VideoTraining() { Title = "Full AGILITY Bodyweight", Description = "An intese workout for people that have experience working out and need a good AGILITY training", Difficulty = Difficulty.Hard, Link = "https://www.youtube.com/watch?v=tveIjnSG_8s", Rating = 2, Time = 67 });
                _liveTrainings.AddTraining(new LiveTraining() { Title = "Workout with John", Description = "Working out can be easy when you are at home. Trust Jonh, he a professional trainer", Difficulty = Difficulty.Medium, NextSession = new DateTime(2020, 07, 20), Trainer = John, Time = 40, Rating = 2 });
                _liveTrainings.AddTraining(new LiveTraining() { Title = "Quickabs  with John", Description = "You want abs for the summer? This is the training for you!!", Difficulty = Difficulty.Hard, NextSession = new DateTime(2020, 07, 24), Trainer = John, Time = 25, Rating = 4 });
            }
        }
        static void Main(string[] args)
        {
            Seed();

            while (true)
            {
                
                if (_currentUser == null)
                {
                    int loginChoice = _uiService.LogInMenu();
                    if (loginChoice == 1)
                    {
                        int roleChoice = _uiService.RoleMenu();
                        UserRole role = (UserRole)roleChoice;
                        Console.Clear();
                        Console.WriteLine("Enter username:");
                        string username = Console.ReadLine();
                        Console.WriteLine("Enter password:");
                        string password = Console.ReadLine();
                        switch (role)
                        {
                            case UserRole.Standard:
                                _currentUser = _standardUserSrvc.LogIn(username, password);
                                break;
                            case UserRole.Premium:
                                _currentUser = _premiumUserSrvc.LogIn(username, password);
                                break;
                            case UserRole.Trainer:
                                _currentUser = _trainerUserSrvc.LogIn(username, password);
                                break;
                        }

                        if (_currentUser == null) continue;
                    }
                    else
                    {
                        StandardUser newUser = new StandardUser();
                        Console.WriteLine("Enter first name:");
                        newUser.FirstName = Console.ReadLine();
                        Console.WriteLine("Enter last name:");
                        newUser.LastName = Console.ReadLine();
                        Console.WriteLine("Enter username:");
                        newUser.Username = Console.ReadLine();
                        Console.WriteLine("Enter password:");
                        newUser.Password = Console.ReadLine();
                        User user = _standardUserSrvc.Register(newUser);
                        if (user == null) continue;
                        _currentUser = user;
                    }
                    _uiService.Welcome(_currentUser);
                }

                int mainMenuChoice = _uiService.MainMenu(_currentUser.Role);
                string mainMenuItem = _uiService.MainMenuItems[mainMenuChoice - 1];
                switch (mainMenuItem)
                {
                    case "Train":
                        int trainChoice = 1;
                        if (_currentUser.Role == UserRole.Premium) trainChoice = _uiService.TrainMenu();
                        if (trainChoice == 1)
                        {
                            int trainingItem = _uiService.TrainMenuItems(_videoTrainings.GetTrainings());
                            VideoTraining training = _videoTrainings.GetTrainings()[trainingItem - 1];
                            Console.WriteLine(training.Title);
                            Console.WriteLine($"Link: {training.Link}");
                            Console.WriteLine($"Raiting: {training.CheckRating()}");
                            Console.WriteLine($"Time: {training.Time} minutes");
                            Console.ReadLine();
                        }
                        if (trainChoice == 2)
                        {
                            int trainingItem = _uiService.TrainMenuItems(_liveTrainings.GetTrainings());
                            LiveTraining training = _liveTrainings.GetTrainings()[trainingItem - 1];
                            Console.WriteLine(training.Title);
                            Console.WriteLine($"THE TRAINING STARTS AT: {training.NextSession}");
                            Console.WriteLine($"Raiting: {training.CheckRating()}");
                            Console.WriteLine($"Time: {training.Time} minutes");
                            Console.ReadLine();
                        }
                        break;
                    case "Upgrade to Premium":
                        _uiService.UpgradeToPremium();
                        break;
                    case "Reschedule Training":
                        List<LiveTraining> trainings = _liveTrainings.GetTrainings().Where(x => x.Trainer.Id == _currentUser.Id).ToList();
                        if (trainings.Count == 0)
                        {
                            Console.WriteLine("No Trainings!");
                            Console.ReadLine();
                        }
                        else
                        {
                            int trainingChoice = _uiService.ChooseEntitiesMenu(trainings);
                            Console.WriteLine("How many days do you want to reschedule the training:");
                            int days = ValidationHelper.ValidateNumber(Console.ReadLine(), 100);
                            _trainerUserSrvc.GetById(_currentUser.Id).ChangeSchedule(trainings[trainingChoice - 1], days);
                            Console.WriteLine("Schedule changed!");
                            Console.ReadLine();
                        }
                        break;
                    case "Account":
                        int accountChoice = _uiService.AccountMenu(_currentUser.Role);
                        if (accountChoice == 1)
                        {
                            //Change Info
                            Console.WriteLine("Enter new First Name:");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Enter new Last Name:");
                            string lastName = Console.ReadLine();
                            switch (_currentUser.Role)
                            {
                                case UserRole.Standard:
                                    _standardUserSrvc.ChangeInfo(_currentUser.Id, firstName, lastName);
                                    break;
                                case UserRole.Premium:
                                    _premiumUserSrvc.ChangeInfo(_currentUser.Id, firstName, lastName);
                                    break;
                                case UserRole.Trainer:
                                    _trainerUserSrvc.ChangeInfo(_currentUser.Id, firstName, lastName);
                                    break;
                            }
                        }
                        else if(accountChoice == 2)
                        {
                            //CheckSubscription
                            Console.WriteLine($"Your subscription is : {_currentUser.Role}");
                            Console.ReadLine();
                        }
                        else if(accountChoice == 3)
                        {
                            // Change Password
                            Console.WriteLine("Enter old password:");
                            string oldPass = Console.ReadLine();
                            Console.WriteLine("Enter new password:");
                            string newPass = Console.ReadLine();
                            switch (_currentUser.Role)
                            {
                                case UserRole.Standard:
                                    _standardUserSrvc.ChangePassword(_currentUser.Id, oldPass, newPass);
                                    break;
                                case UserRole.Premium:
                                    _premiumUserSrvc.ChangePassword(_currentUser.Id, oldPass, newPass);
                                    break;
                                case UserRole.Trainer:
                                    _trainerUserSrvc.ChangePassword(_currentUser.Id, oldPass, newPass); 
                                    break;
                                default:
                                    break;
                            }
                        }
                        break;

                    case "Log Out":
                        _currentUser = null;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

