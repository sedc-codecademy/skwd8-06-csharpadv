using SEDC.TryBeingFit.Domain.Core;
using SEDC.TryBeingFit.Domain.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Services.Services
{
	public interface IUIService
	{
		void Welcome(User user);
		int ChooseEntiiesMenu<T>(List<T> entities) where T : IBaseEntity;
		int MainMenu(UserRole role);
		int ChooseMenu<T>(List<T> items);
		int LogInMenu();
		int RoleMenu();
	}
}
