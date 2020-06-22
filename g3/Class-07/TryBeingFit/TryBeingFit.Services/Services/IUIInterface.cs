using System;
using System.Collections.Generic;
using System.Text;
using TryBeingFit.Domain.Core.Entities;
using TryBeingFit.Domain.Core.Enums;

namespace TryBeingFit.Services.Services
{
    public interface IUIInterface
    {
        void Welcome(User user);
        int ChooseEntitiesMenu<T>(List<T> entities) where T : IBaseEntity;
        int MainMenu(UserRole role);
        int ChooseMenu<T>(List<T> items);
        int LogInMenu();
        int RoleMenu();
    }
}
