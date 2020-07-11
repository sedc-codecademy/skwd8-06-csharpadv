using SEDC.Adv.TryBeingFit.Domain;
using SEDC.Adv.TryBeingFit.Services;
using SEDC.Adv.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Adv.TryBeingFit.App
{
    // Creating the structure:
    // 
    // Refferences
    // Services need a refference to domain
    // App need both domain and services
    //
    // When we are connecting references there can't be a circle from the refrences
    // This means that as long as the references connect to each other but don't for ma loop we are fine
    // When references point one to each other then we have a problem of circular reference

    // Domain structure
    // Core -> A folder with all business logic entities
    // -- Entities      -> All the classes
    // -- Enumerations  -> All the enums
    // -- Interfaces    -> All the interfaces

	class Program
	{
        public static IUiService _uiSrvc = new UiService();
        public static IUserService<StandardUser> _standardUserSrvc = new UserService<StandardUser>();
        public static IUserService<PremiumUser> _premiumUserSrvc = new UserService<PremiumUser>();
        public static IUserService<TrainerUser> _trainerUserSrvc = new UserService<TrainerUser>();
        public static ITrainingService<VideoTraining> _videoTrainings = new TrainingService<VideoTraining>();
        public static ITrainingService<LiveTraining> _liveTrainings = new TrainingService<LiveTraining>();
        public static User _currentUser;

        // This method will be called at the start of the application
        // It will register some inital users so that we have some users to work with when the app starts
        public static void Seed()
        {
            if (_standardUserSrvc.IsDbEmpty() && _premiumUserSrvc.IsDbEmpty() && _trainerUserSrvc.IsDbEmpty())
            {
                _standardUserSrvc.Register(new StandardUser() { FirstName = "Bob", LastName = "Bobsky", Username = "bobob1", Password = "bobbest1" });
                _premiumUserSrvc.Register(new PremiumUser() { FirstName = "Jill", LastName = "Wayne", Username = "jilllw", Password = "jillsuper26" });
                TrainerUser John = new TrainerUser() { FirstName = "John", LastName = "Johnsky", Username = "johnjj", Password = "johny55", YearsExperience = 7 };
                _trainerUserSrvc.Register(John);
                _videoTrainings.AddTraining(new VideoTraining() { Title = "30 min workout", Description = "Cool workout for beginners and intermediate users", Difficulty = Difficulty.Medium, Link = "https://www.youtube.com/watch?v=50kH47ZztHs", Rating = 4, Time = 35 });
                _videoTrainings.AddTraining(new VideoTraining() { Title = "Standing ABS workout", Description = "Abs workout for people at home with standing and no equipment required", Difficulty = Difficulty.Easy, Link = "https://www.youtube.com/watch?v=Qia2ZXEzyLw", Rating = 5, Time = 11 });
                _videoTrainings.AddTraining(new VideoTraining() { Title = "Full AGILITY Bodyweight", Description = "An intense workout for people that have experience working out and need a good AGILITY training", Difficulty = Difficulty.Hard, Link = "https://www.youtube.com/watch?v=tveIjnSG_8s", Rating = 2, Time = 67 });
                _liveTrainings.AddTraining(new LiveTraining() { Title = "Workout with John", Description = "Working out can be easy when you are at home. Trust John, he is a professional!", Difficulty = Difficulty.Medium, NextSession = new DateTime(2020, 07, 20), Trainer = John, Rating = 2, Time = 25 });
                _liveTrainings.AddTraining(new LiveTraining() { Title = "Quick abs with John", Description = "You want abs for the summer? You want them quick? This is the training for you!", Difficulty = Difficulty.Hard, NextSession = new DateTime(2020, 07, 24), Trainer = John, Rating = 4, Time = 40 });
            }
        }
        static void Main(string[] args)
		{
            // Calling the seed method in order to fill in the database with inital data if it is empty
            Seed();
			while (true)
			{
                // If it is null, it means that nobody is logged in
                // We can generate the menu for log in
                if(_currentUser == null)
				{
                    // Menu for log in or register
                    // Program -> Log in Menu method -> Generate a new menu method -> Validate a number
                    // Validate a number -> Generate a new menu mehod -> Log in Menu method -> Program
                    int loginChoice = _uiSrvc.LogInMenu();
                    // This if checks if the number the user entered is 1. If it is give them log in menu
                    if(loginChoice == 1)
					{
                        // Menu for the user role if they want to log in
                        int roleChoice = _uiSrvc.RoleMenu();
                        // We map the user choice of 1 2 or 3 to the enum so we can have it as an enum
                        UserRole role = (UserRole)roleChoice;
                        // UserRole brokenRole = UserRole.1; // This will not work
                        // UserRole standard = (UserRole)1; // This will work and will get the Standard enum since it is number 1 in the enum
                        Console.Clear();
                        // Give the log in menu if they want to log in
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
                    // If the user enters 2, the if(loginChoice == 1) will get skipped 
                    // And this else statement will get executed
                    else
					{
                        // Give the register menu if they want to register
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
                    _uiSrvc.Welcome(_currentUser);
                }

                int mainMenuChoice = _uiSrvc.MainMenu(_currentUser.Role);
                string mainMenuItem = _uiSrvc.MainMenuItems[mainMenuChoice - 1];
                switch (mainMenuItem)
                {
                    case "Train":
                        // We have 2 kinds of training: Video and Live
                        // But standard users only have access to Video and not Live, while Premium have access to both
                        // Because this is the case we set the default choice to 1, which corelates to Video Trainings
                        // IF the user is premium we give them a choice to pick Live or Video and then change the choice accordingly
                        int trainChoice = 1;
                        if (_currentUser.Role == UserRole.Premium) trainChoice = _uiSrvc.TrainMenu();
                        // Video trainings 
                        if (trainChoice == 1)
                        {
                            int trainingItem = _uiSrvc.TrainMenuItems(_videoTrainings.GetTrainings());
                            VideoTraining training = _videoTrainings.GetTrainings()[trainingItem - 1];
                            Console.WriteLine(training.Title);
                            Console.WriteLine($"Link: {training.Link}");
                            Console.WriteLine($"Raiting: {training.CheckRating()}");
                            Console.WriteLine($"Time: {training.Time} minutes");
                            Console.ReadLine();
                        }
                        // Live trainings
                        if (trainChoice == 2)
                        {
                            int trainingItem = _uiSrvc.TrainMenuItems(_liveTrainings.GetTrainings());
                            LiveTraining training = _liveTrainings.GetTrainings()[trainingItem - 1];
                            Console.WriteLine(training.Title);
                            Console.WriteLine($"THE TRAINING STARTS AT: {training.NextSession}");
                            Console.WriteLine($"Raiting: {training.CheckRating()}");
                            Console.WriteLine($"Time: {training.Time} minutes");
                            Console.ReadLine();
                        }
                        break;
                    case "Upgrade to Premium":
                        _uiSrvc.UpgradeToPremium();
                        break;
                    case "Reschedule training":
                        List<LiveTraining> trainings = _liveTrainings.GetTrainings().Where(x => x.Trainer.Id == _currentUser.Id).ToList();
                        if (trainings.Count == 0)
                        {
                            Console.WriteLine("No Trainings!");
                            Console.ReadLine();
                        }
                        else
                        {
                            int trainingChoice = _uiSrvc.ChooseEntiiesMenu(trainings);
                            Console.WriteLine("How many days do you want to reschedule the training:");
                            int days = ValidationHelper.ValidateNumber(Console.ReadLine(), 100);
                            _trainerUserSrvc.GetUserById(_currentUser.Id).ChangeSchedule(trainings[trainingChoice - 1], days);
                            Console.WriteLine("Schedule changed!");
                            Console.ReadLine();
                        }
                        break;
                    case "Account":
                        int accountChoice = _uiSrvc.AccountMenu(_currentUser.Role);
                        Console.Clear();
                        if (accountChoice == 1)
                        {
                            // Change Info
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
                        else if (accountChoice == 2)
                        {
                            // Check Subscription
                            Console.WriteLine($"Your subscription is: {_currentUser.Role}");
                            Console.ReadLine();
                        }
                        else if (accountChoice == 3)
                        {
                            // Change info
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
