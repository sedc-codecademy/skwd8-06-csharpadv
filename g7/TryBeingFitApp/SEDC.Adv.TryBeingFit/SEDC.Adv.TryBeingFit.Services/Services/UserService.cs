using SEDC.Adv.TryBeingFit.Domain;
using SEDC.Adv.TryBeingFit.Domain.Db;
using SEDC.Adv.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services
{
	public class UserService<T> : IUserService<T> where T : User
	{
		// We add access to the database here
		private IDb<T> _db;
		public UserService()
		{
			// We create an instance of the DataBase manipulation class
			_db = new FileSystemDb<T>();
		}

		public T GetUserById(int id)
		{
			// Security question
			// Check token
			// Check authentication
			// Check if it's logged in
			return _db.GetById(id);
		}

		// Here the service ONLY CARES ABOUT LOG IN A PERSON WITH GIVEN USERNAME AND PASSWORD
		// Validations can be added in two places: 
		// 1. Where the user inserts the data -> You decide on the spot if the validations are valid
		// 2. Where the login tries to happen -> You have to get to the login to decide if the values are valid

		// We use the 1. option for validations
		public T LogIn(string username, string password)
		{
			#region Initial Implementation
			//// Match username and password to user in database
			//// We get all the users
			//List<T> allUsers = _db.GetAll();
			//// We need to go through them all and match the username and password
			//T userFound = allUsers.SingleOrDefault(x => x.Username == username && x.Password == password);
			//// Detect if there really was a user with that name
			//if(userFound == null)
			//{
			//	// Generate an error message
			//	Console.ForegroundColor = ConsoleColor.Red;
			//	Console.WriteLine("[Error] Username or Password did not match! Please try again!");
			//	Console.ResetColor();
			//	Console.ReadLine();
			//	// return null since we didn't find the user
			//	return null;
			//}
			//return userFound;
			#endregion

			T userFound = _db.GetAll().SingleOrDefault(x => x.Username == username && x.Password == password);
			if (userFound == null)
			{
				MessageHelper.PrintMessage("[Error] Username or Password did not match! Please try again!", ConsoleColor.Red);
				return null;
			}
			return userFound;
		}

		// We use the 2. option for validations
		public T Register(T user)
		{
			if (ValidationHelper.ValidateString(user.FirstName) == null
				|| ValidationHelper.ValidateString(user.LastName) == null
				|| ValidationHelper.ValidateUsername(user.Username) == null
				|| ValidationHelper.ValidatePassword(user.Password) == null)
			{
				MessageHelper.PrintMessage("[Error] Invalid information!", ConsoleColor.Red);
				return null;
			}
			int id = _db.Insert(user);
			// T newUser = _db.GetById(id); -> We made this shorter so we don't need this line any more
			return _db.GetById(id);
		}

		// #Added
		public void ChangeInfo(int userId, string firstName, string lastName)
		{
			T user = _db.GetById(userId);
			if (ValidationHelper.ValidateString(firstName) == null || ValidationHelper.ValidateString(lastName) == null)
			{
				MessageHelper.PrintMessage("[Error] strings were not valid. Please try again!", ConsoleColor.Red);
				Console.ReadLine();
				return;
			}
			user.FirstName = firstName;
			user.LastName = lastName;
			_db.Update(user);
			MessageHelper.PrintMessage("Data successfuly changed!", ConsoleColor.Green);
			Console.ReadLine();
		}

		public void ChangePassword(int userId, string oldPassword, string newPassword)
		{
			T user = _db.GetById(userId);
			if (user.Password != oldPassword)
			{
				MessageHelper.PrintMessage("[Error] Old password did not match", ConsoleColor.Red);
				Console.ReadLine();
				return;
			}
			if (ValidationHelper.ValidateString(newPassword) == null)
			{
				MessageHelper.PrintMessage("[Error] New password is not valid", ConsoleColor.Red);
				Console.ReadLine();
				return;
			}
			user.Password = newPassword;
			_db.Update(user);
			MessageHelper.PrintMessage("Password successfuly changed!", ConsoleColor.Green);
			Console.ReadLine();
		}

		public bool IsDbEmpty()
		{
			return _db.GetAll() == null || _db.GetAll().Count == 0;
		}
	}
}
