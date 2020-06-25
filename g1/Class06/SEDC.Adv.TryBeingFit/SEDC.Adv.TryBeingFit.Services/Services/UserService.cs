using SEDC.Adv.TryBeingFit.Domain.Db;
using SEDC.Adv.TryBeingFit.Domain.Entities;
using SEDC.Adv.TryBeingFit.Services.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services.Services
{
	public class UserService<T> where T : User
	{
		private IDb<T> _db;
		public UserService()
		{
			_db = new LocalDb<T>();
		}
	}
}
