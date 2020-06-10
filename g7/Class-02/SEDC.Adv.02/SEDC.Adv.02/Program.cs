using SEDC.Adv._02.Entities;
using System;

namespace SEDC.Adv._02
{
	class Program
	{
        private static User _currentUser;
		static void Main(string[] args)
		{
            #region Examples
            // We can't create an instance of a static class
            // This does not mean that an instance does not exist from this class
            // Static class actually has an instance but it is created automatically when the app starts
            // That is why you can't create a new instance from it. There is already an instance 
            // And since there can only be one instance of a static class, there is no reason for a developer to create a new one
            // TextHelper txt = new TextHelper(); // This gives an error
            // Static class is the same for EVERYBODY EVERYWHERE
            // Normal class is sepparate for each context ( between {} brackets )
            Console.WriteLine("NOT THE APP");
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            string capitalLetterInput = TextHelper.CapitalFirstLetter(input);
            User bob = new User(1, "bob22", "Bob Street");
            // You can't call methods on normal classes without an instance, like we can with the static classes
            // User.PrintInfo(); // this gives an error
            // We can now use PrintInfo because we have an instance
            bob.PrintInfo();
            Console.WriteLine($"Your string: {capitalLetterInput}");
            Console.WriteLine($"The capital letter method was used {TextHelper.CapitalLetterUses} times!");
            Console.ReadLine();
            Console.Clear();
            #endregion

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the ordering menu!");
                Console.WriteLine("Choose a User:");
                OrdersTempDB.ListUsers();
                // We show:
                // 1) Bob ( is on index 0 )
                // 2) Jill ( is on index 1 )
                int userChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
                if (userChoice == -1) continue;
                _currentUser = OrdersTempDB.Users[userChoice - 1];

                Console.Clear();
                Console.WriteLine("Order Menu");
                Console.WriteLine("1) Check Orders");
                Console.WriteLine("2) Add new order");
                int menuChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
                if (menuChoice == -1) continue;
                if(menuChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Choose an order to check the status:");
                    _currentUser.PrintOrders();
                    int orderInput = TextHelper.ValidateNumberInput(Console.ReadLine());
                    if (orderInput == -1) continue;
                    // The menu:
                    // 1) order1 ( index 0 )
                    // 2) order2 ( index 1 )
                    // 3) order3 ( index 2 ) -> That's why we have Orders[orderInput - 1]

                    // We call the generatestatusmessage method which will print a message for us depending on the stauts of the selected order by the user
                    // 1. We go in the current user
                    // 2. We find all their orders
                    // 3. We select the index - 1 order from that list ( because the menu starts from 1 and the list from 0 )
                    // 4. We take the status from that order
                    // 5. We give that status to the GenerateStatusMessage
                    // 6. GenerateStatusMessage decides which message to write depending on the status
                    // 7. A message appears on the screen
                    TextHelper.GenerateStatusMessage(_currentUser.Orders[orderInput - 1].Status);
                    Console.ReadLine();
                } else if (menuChoice == 2)
                {
                    Console.Clear();
                    Order newOrder = new Order();
                    Console.WriteLine("Write the title of the order:");
                    newOrder.Title = Console.ReadLine();
                    Console.WriteLine("Write the description of the order:");
                    newOrder.Description = Console.ReadLine();
                    newOrder.Status = OrderStatus.Processing;
                    OrdersTempDB.InsertOrder(_currentUser.Id, newOrder);
                    Console.ReadLine();

                } else
                {
                    Console.WriteLine("Wrong input!");
                    Console.ReadLine();
                    continue;
                }
                
            }
        }
    }
}
