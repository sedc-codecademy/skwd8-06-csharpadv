using System;
using System.IO;
using System.Net.Http.Headers;

namespace Statics
{
    class Program
    {
        // static UserManager um = new UserManager();

        static void Main(string[] args)
        {
            // Calculating();

            //Console.WriteLine("Get username");
            //string username = Console.ReadLine();
            //Console.WriteLine("Get password");
            //string password = Console.ReadLine();

            //BadStatic.SetUser(username, password);
            //RunStuffNonAdmin();
            //BadStatic.SetUser("Admin", password);
            //RunStuffAdmin();
            //BadStatic.SetUser(username, password);
            //RunStuffNonAdmin();

            //Console.WriteLine("--------------");

            //UserManager um = new UserManager();
            //um.SetUser(username, password);
            //RunStuff2NonAdmin(um);

            //var adminUm = um.Impersonate();
            //RunStuff2Admin(adminUm);

            //RunStuff2NonAdmin(um);

            Console.WriteLine("-----------");
            var x = Calculator.Multiply(1, 2, 3);
            Console.WriteLine(x.GetType().FullName);
        }

        private static void RunStuffNonAdmin()
        {
            Console.WriteLine($"Should not be admin {BadStatic.UserName}");
        }

        private static void RunStuffAdmin()
        {
            if (BadStatic.UserName != "Admin")
            {
                throw new InvalidOperationException("NOT AN ADMIN");
            }
            Console.WriteLine("Successfully ran");
        }

        private static void RunStuff2NonAdmin(UserManager um)
        {
            Console.WriteLine($"Should not be admin {um.UserName}");
        }

        private static void RunStuff2Admin(UserManager um)
        {
            if (um.UserName != "Admin")
            {
                throw new InvalidOperationException("NOT AN ADMIN");
            }
            Console.WriteLine("Successfully ran");
        }

        private static void Calculating()
        {
            Console.WriteLine("Enter first number");
            int.TryParse(Console.ReadLine(), out int first);

            Console.WriteLine("Enter second number");
            int.TryParse(Console.ReadLine(), out int second);

            Console.WriteLine("Enter operation");
            string op = Console.ReadLine();

            switch (op)
            {
                case "*":
                    // do multiplication
                    Console.WriteLine(Calculator.Multiply(first, second));
                    break;
                case "^":
                    // do exponentiation
                    Console.WriteLine(Calculator.Exponent(first, second));
                    break;
                case "/":
                    // do proper division
                    var (result, remainder) = Calculator.Divide(first, second);
                    Console.WriteLine(result);
                    Console.WriteLine(remainder);
                    break;
                case "c":
                    Console.WriteLine(Calculator.CircleLenght(first));
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}
