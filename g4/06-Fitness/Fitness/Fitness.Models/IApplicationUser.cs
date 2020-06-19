using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Models
{
    public interface IApplicationUser
    {
        int ID { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string UserName { get; set; }

        string Password { get; set; }

        string FullName { get; }

        bool IsLoggedIn { get; }

        void ShowAccount();

        bool Login();

        void Logoff();
    }
}
