using SEDC.Adv.TryBeingFit.Domain;
using SEDC.Adv.TryBeingFit.Services;
using System;

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
        public static IUserService<StandardUser> _standardUserSrvc = new UserService<StandardUser>();
        public static IUserService<PremiumUser> _premiumUserSrvc = new UserService<PremiumUser>();
        public static IUserService<TrainerUser> _trainerUserSrvc = new UserService<TrainerUser>();
        public static IUiService _uiSrvc = new UiService();
        public static User _currentUser;

        // This method will be called at the start of the application
        // It will register some inital users so that we have some users to work with when the app starts
        public static void Seed()
        {
            _standardUserSrvc.Register(new StandardUser() { FirstName = "Bob", LastName = "Bobsky", Username = "bobob1", Password = "bobbest1" });
            _premiumUserSrvc.Register(new PremiumUser() { FirstName = "Jill", LastName = "Wayne", Username = "jilllw", Password = "jillsuper26" });
            TrainerUser John = new TrainerUser() { FirstName = "John", LastName = "Johnsky", Username = "johnjj", Password = "johny55", YearsExperience = 7 };
            _trainerUserSrvc.Register(John);
        }
        static void Main(string[] args)
		{
            Seed();
			while (true)
			{
                // If it is null, it means that nobody is logged in
                // We can generate the menu for log in
                if(_currentUser == null)
				{
                    // Menu for log in or register
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
                    } 
                    // If the user enters 2, the if(loginChoice == 1) will get skipped 
                    // And this else statement will get executed
                    else
					{
                        // Give the register menu if they want to register
                        Console.WriteLine("------Registration Form------");
                        Console.ReadLine();
					}








                }
            }

        }
	}
}
