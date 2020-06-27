using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Services
{
	public interface IUiService
	{
		int RoleMenu();
		int LogInMenu();
		int ChooseMenu<T>(List<T> items);

	}
}
