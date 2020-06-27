using SEDC.Adv.TryBeingFit.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.ExampleOnly
{
	public class FacebookUserService<T> : IUserService<T> where T : User
	{
		public T GetUserById(int id)
		{
			throw new NotImplementedException();
		}

		public T LogIn(string username, string password)
		{
			throw new NotImplementedException();
		}

		public T Register(T User)
		{
			throw new NotImplementedException();
		}
	}
}
