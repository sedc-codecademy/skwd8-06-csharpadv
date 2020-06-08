using QuizUserManagement;

using System;

namespace QuizMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = LoginUser();

            if (user == null)
            {
                Console.WriteLine("Unsuccessful login attempt");
            }
            else
            {
                Console.WriteLine($"Welcome {user.FullName}");
            }

        }

        private static User? LoginUser()
        {
            var userrepo = new UserRepository();

            Console.Clear();
            Console.WriteLine("Enter username: ");
            var username = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            var password = Console.ReadLine();

            var user = userrepo.Login(username, password);
            return user;
        }
    }
}
