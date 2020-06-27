using SEDC.Adv.TryBeingFit.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services
{
	public interface IUserService<T> where T : User
	{
		T LogIn(string username, string password);
		T Register(T user);
		T GetUserById(int id);
	}
}
