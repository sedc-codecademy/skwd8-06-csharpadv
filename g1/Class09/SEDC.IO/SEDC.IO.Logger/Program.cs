using SEDC.IO.Logger.Entities;
using SEDC.IO.Logger.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.IO.Logger
{
    class Program
    {
        static List<User> Users = new List<User>
        {
            new User(){ Id = 1, Username="JhonDoe", Password="1234", Age = 20 },
            new User(){ Id = 2, Username="JaneDoe", Password="5678", Age = 22 },
            new User(){ Id = 3, Username="JillDoe", Password="91011", Age = 29 }
        };

        public static int Login(string username, string password)
        {
            User user = Users.SingleOrDefault(user =>
                user.Username == username && user.Password == password);

            if (user == null)
            {
                throw new InvalidUserException("Invalid credentials.");
            }

            Console.WriteLine($"Welcome {user.Username}");

            return user.Id;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");

            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();

            Login(username, password);
        }
    }
}
