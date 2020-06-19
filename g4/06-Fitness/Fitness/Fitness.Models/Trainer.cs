using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Models
{
    public class Trainer : IApplicationUser
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; }
        public bool IsLoggedIn { get; private set; }

        public bool Login()
        {
            Console.WriteLine($"[INFO]: Employee {ID} started working in @ {DateTime.Now.ToShortTimeString()}");
            IsLoggedIn = true;
            return IsLoggedIn;
        }

        public void Logoff()
        {
            Console.WriteLine($"[INFO]: Employee {ID} stopped working @ {DateTime.Now.ToShortTimeString()}");
            IsLoggedIn = false;
        }

        public void ShowAccount()
        {
            Console.WriteLine($"EmployeeID: {ID}");
            Console.WriteLine($"Name: {FullName}");
        }
    }
}
