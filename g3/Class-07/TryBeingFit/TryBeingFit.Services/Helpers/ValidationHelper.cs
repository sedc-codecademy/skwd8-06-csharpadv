using System;
using System.Collections.Generic;
using System.Text;

namespace TryBeingFit.Services.Helpers
{
    public class ValidationHelper
    {
		//Validates the number to check whether it is really a number and if it is whether it is in the range that is supposed to be
		public static int ValidateNumber(string number, int range)
		{
			int num = 0;
			bool isNumber = int.TryParse(number, out num);
			if (!isNumber) return -1;
			if (num <= 0 || num > range) return -1;
			return num;
		}
		//Validates the string by checking if it is longer than 2 characters and also checks whether it's a number typed  
		public static string ValidateString(string str)
		{
			if (str.Length < 2) return null;
			int number;
			if (int.TryParse(str, out number)) return null;
			return str;
		}
		//Validates the username by checking if it is longer than 6 characters
		public static string ValidateUsername(string username)
		{
			if (username.Length < 6) return null;
			return username;

		}
		//Validates the password by checking if it is longer than 6 characters and whether it has number in it as a character
		public static string ValidatePassword(string password)
		{
			if (password.Length < 6) return null;
			int num;
			bool isNum = false;
			foreach (char item in password)
			{
				isNum = int.TryParse(item.ToString(), out num);
			}
			if (!isNum) return null;
			return password;
		}
	}
}
