using SEDC.Adv.TryBeingFit.Domain;
using System;
using System.Collections.Generic;
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
			_db = new LocalDb<T>();
		}

		public T GetUserById(int id)
		{
			throw new NotImplementedException();
		}

		// Here the service ONLY CARES ABOUT LOG IN A PERSON WITH GIVEN USERNAME AND PASSWORD
		// Validations can be added in two places: 
		// 1. Where the user inserts the data -> You decide on the spot if the validations are valid
		// 2. Where the login tries to happen -> You have to get to the login to decide if the values are valid
		public T LogIn(string username, string password)
		{
			// Match username and password to user in database
			// We get all the users
			List<T> allUsers = _db.GetAll();
			// We need to go through them all and match the username and password
			T userFound = allUsers.SingleOrDefault(x => x.Username == username && x.Password == password);
			// Detect if there really was a user with that name
			if(userFound == null)
			{
				// Generate an error message
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("[Error] Username or Password did not match! Please try again!");
				Console.ResetColor();
				Console.ReadLine();
				// return null since we didn't find the user
				return null;
			}
			return userFound;
		}

		public T Register(T User)
		{
			throw new NotImplementedException();
		}
	}
}
