using System;
using TryBeingFit.Domain.Core.Entities;
using TryBeingFit.Domain.Core.Enums;
using TryBeingFit.Services.Services;

namespace TryBeingFit.App
{
    class Program
    {
		public static IUIInterface _uiService = new UIService();
		public static IUserService<StandardUser> _standardUserSrvc = new UserService<StandardUser>();
		public static IUserService<PremiumUser> _premiumUserSrvc = new UserService<PremiumUser>();
		public static IUserService<TrainerUser> _trainerUserSrvc = new UserService<TrainerUser>();
		public static User _currentUser;

		public static void Seed()
		{
			_standardUserSrvc.Register(new StandardUser() { FirstName = "Bob", LastName = "Bobsky", Username = "bobob1", Password = "bobbest1" });
			_premiumUserSrvc.Register(new PremiumUser() { FirstName = "Jill", LastName = "Wayne", Username = "jilllw", Password = "jillsuper26" });
			_trainerUserSrvc.Register(new TrainerUser() { FirstName = "John", LastName = "Johnsky", Username = "johnjj", Password = "johny55" });
		}
		static void Main(string[] args)
		{
			Seed();
			while (true)
			{
				Console.Clear();
				int loginChoice = _uiService.LogInMenu();
				Console.Clear();
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
							_currentUser = _standardUserSrvc.Login(username, password);
							break;
						case UserRole.Premium:
							_currentUser = _premiumUserSrvc.Login(username, password);
							break;
						case UserRole.Trainer:
							_currentUser = _trainerUserSrvc.Login(username, password);
							break;
					}

					if (_currentUser == null) continue;
					break;
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
				}
			}
			Console.Clear();
			_uiService.Welcome(_currentUser);
			_uiService.MainMenu(_currentUser.Role);
		}
	}
}
