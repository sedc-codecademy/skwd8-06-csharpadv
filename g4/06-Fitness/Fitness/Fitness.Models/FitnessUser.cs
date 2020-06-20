using System;
using System.Collections.Generic;
using System.Text;

namespace Fitness.Models
{
    public abstract class FitnessUser : IApplicationUser
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName => $"{FirstName} {LastName}";

        public bool IsLoggedIn { get; private set; } 

        public bool Login()
        {
            Console.WriteLine($"[INFO]: User {ID} logged in @ {DateTime.Now.ToShortTimeString()}");
            IsLoggedIn = true;
            return IsLoggedIn;
        }

        public void Logoff()
        {
            Console.WriteLine($"[INFO]: User {ID} logged off @ {DateTime.Now.ToShortTimeString()}");
            IsLoggedIn = false;
        }

        public void ShowAccount()
        {
            Console.WriteLine($"UserID: {ID}");
            Console.WriteLine($"Name: {FullName}");
        }

        public abstract void StartVideoTraining();

        //public virtual void StartVideoTraining();
        //{
        //    Console.WriteLine($"Starting video training in low-res for user {FullName}");
        //}
    }
}
