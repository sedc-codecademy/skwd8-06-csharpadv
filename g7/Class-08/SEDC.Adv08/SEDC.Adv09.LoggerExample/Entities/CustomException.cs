using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv09.LoggerExample.Entities
{
	// We will throw this exception when a property is entered but it is incorrect format for a user
	public class InvalidUserPropertyException : Exception
	{
		private LoggerService _logger = new LoggerService();
		public string BrokenProperty { get; set; }
		public string BrokenValue { get; set; }
		public string User { get; set; }
		
		// We are inheriting from Exception
		// Exception as a perent has a constructor that accepts a string
		// That string is added in to the exception message
		// When we write base("some message") we are adding a message directly to the Exception it self
		// This message will show up in the Exception box and everywhere we need it
		public InvalidUserPropertyException()
			: base("Unknown user had an invalid value for a user property!")
		{
			_logger.UpdateErrorCount();
		}

		// We have 2 constructors
		// One is used if we have no information of who broke our app
		// The second is if we already have a loged in user and we can document who was it and what were the changes
		public InvalidUserPropertyException(string property, string value, string username)
			: base($"The user {username} entered wrong input for the {property} property ({value})")
		{
			BrokenProperty = property;
			BrokenValue = value;
			User = username;
			_logger.UpdateErrorCount();
		}
	}

	// When a user has problems logging in we can use this exception
	public class InvalidLoginException : Exception
	{
		private LoggerService _logger = new LoggerService();
		public string Username { get; set; }
		public InvalidLoginException(string username)
			: base("User entered wrong login information!")
		{
			Username = username;
			_logger.UpdateErrorCount();
		}
	}
}
