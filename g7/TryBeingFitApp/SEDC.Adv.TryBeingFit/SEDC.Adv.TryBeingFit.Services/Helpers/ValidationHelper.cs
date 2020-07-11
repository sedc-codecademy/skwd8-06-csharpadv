using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.Helpers
{
	public static class ValidationHelper
	{
		// This method is a generic and dynamic validate number method
		// It validates numbers by type and by range
		// If the number is not the correct type or in the range it returns -1 that represents bad value
		public static int ValidateNumber(string number, int range)
		{
			int num = 0;
			bool isNumber = int.TryParse(number, out num);
			if (!isNumber) return -1;
			if (num <= 0 || num > range) return -1;
			return num;
		}

		public static string ValidateString(string str)
		{
			// Remove empty spaces
			str = str.Trim();
			// Validate for length
			if (str.Length < 2) return null;
			// Validate for having at least 1 int in the string
			int number;
			bool hasNumber = false;
			// foreach on a string loops through all the characters from that string
			foreach (char character in str)
			{
				// We convert the character to string because the method TryParse accepts string as first parameter
				if(int.TryParse(character.ToString(), out number))
				{
					hasNumber = true;
				}
			}
			if (hasNumber) return null;
			return str;
		}

		public static string ValidateUsername(string username)
		{
			// Remove empty spaces
			username = username.Trim();
			// Validate for length
			if (username.Length < 6) return null;
			return username;
		}
		
		public static string ValidatePassword(string password)
		{
			// Remove empty spaces
			password = password.Trim();
			// Validate for length
			if (password.Length < 6) return null;
			// Validate for having at least 1 int in the string
			int number;
			bool hasNumber = false;
			// foreach on a string loops through all the characters from that string
			foreach (char character in password)
			{
				// We convert the character to string because the method TryParse accepts string as first parameter
				if (int.TryParse(character.ToString(), out number))
				{
					hasNumber = true;
				}
			}
			if (!hasNumber) return null;
			return password;
		}
	}
}
