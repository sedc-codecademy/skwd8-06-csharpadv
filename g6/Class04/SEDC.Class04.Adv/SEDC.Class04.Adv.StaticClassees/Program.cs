using SEDC.Class04.Adv.StaticClassees.Entities;
using System;

namespace SEDC.Class04.Adv.StaticClassees
{
    class Program
    {
        static User _currentUser;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the ordering menu!");
                if(TextHelper.MessageGenerated != 0)
                {
                    Console.WriteLine(
                        $"Fun fact: People checked there order status {TextHelper.MessageGenerated} times!");
                }
                Console.WriteLine("Choose user");
                OrdersTempDB.ListUsers();
                int userChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
                if(userChoice == -1)
                {
                    continue;
                }
                _currentUser = OrdersTempDB.Users[userChoice - 1];

                Console.Clear();
                Console.WriteLine("Orders menu");
                Console.WriteLine("1) Check Orders");
                Console.WriteLine("2) Add new Order");
                int menuChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
                if(menuChoice == -1)
                {
                    continue;
                }

                if(menuChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Choose one to check the status:");
                    _currentUser.PrintOrders();
                    int orderChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
                    if(orderChoice == -1)
                    {
                        continue;
                    }
                    TextHelper.GenerateStatusMessage(_currentUser.Orders[orderChoice - 1].Status);
                    Console.ReadLine();
                }
                else if(menuChoice == 2)
                {
                    Console.Clear();
                    Order order = new Order();
                    Console.WriteLine("Enter order name: ");
                    order.Title = Console.ReadLine();
                    Console.WriteLine("Enter order description: ");
                    order.Description = Console.ReadLine();
                    OrdersTempDB.InsertOrder(_currentUser.Id, order);
                    Console.ReadLine();
                }
            }
        }
    }
}
