using Adv.Class03.Exercise.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class03.Exercise.Entities
{
	public abstract class User : IUser
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public abstract void PrintUser();


	}
}
