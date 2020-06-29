using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv09.LoggerExample.Entities
{
	public class User
	{
		public int Id { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		private int _age;
		public int Age
		{
			// Standard getter
			get
			{
				return _age;
			}
			// Custom setter that detects what value is added and validate that value
			// Every time somebody tries to do user.Age = -1 it will throw an error and will not save the value
			// The property validates it self. It is an strong and independant property and needs no developer
			set
			{
				if(value < 0)
				{
					throw new InvalidUserPropertyException("Age", value.ToString(), Username);
				}
				_age = value;
			}
		}
	}
}
