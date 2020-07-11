using SEDC.Adv.TryBeingFit.Domain;
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

		// #Added
		List<string> MainMenuItems { get; set; }
		List<string> AccountMenuItems { get; set; }
		void Welcome(User user);
		int ChooseEntiiesMenu<T>(List<T> entities) where T : IBaseEntity;
		int MainMenu(UserRole role);
		int AccountMenu(UserRole role);
		int TrainMenu();
		int TrainMenuItems<T>(List<T> trainings) where T : Training;
		void UpgradeToPremium();
	}
}
