using Static.Entities;
using System;

namespace Static
{
    class Program
    {
        static User _currentUser;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //TextHelper textH = new TextHelper(); //skdjfhsd, sdfsdf, sdfsd
            //textH.CaspitalFirstLetter("alek");

            Console.WriteLine(TextHelper.CapitalFirstLetter("alek"));

            Order ord1 = new Order();
            //ord1.Id = 5;
            //ord1.id = 5 //NOT POSSIBLE
            //ord1.setId();
            if (Order.IsOrderValid(ord1))
                Console.WriteLine($"{ord1.Title} is valid");

            Order ord2 = new Order(155, "Test order", "This is only for testing purposes!", OrderStatus.Delivered);
            if (Order.IsOrderValid(ord2))
                Console.WriteLine($"{ord2.Title} is valid");



            while (true)
            {
                #region User Interface
                #region MainMenu
                Console.Clear();
                Console.WriteLine("Welcome to the ordering menu!");
                if (TextHelper.MessagesGenerated != 0)
                    Console.WriteLine($"Fun fact: People checked their order status {TextHelper.MessagesGenerated} times");
                Console.WriteLine("Please choose a user:");
                OrdersTempDB.ListUsers();
                int userChoice = TextHelper.ValidateNumberInput(Console.ReadLine()); //Convert.ToInt32(Console.ReadLine());
                _currentUser = OrdersTempDB.Users[userChoice - 1];
                //TextHelper.GenerateStatusMesage(_currentUser.Orders[2].Status);
                #endregion
                //THIS ONE IS NEW. TAKE A LOOK AND CONTANCT UP FOR ANYTHING
                #region Orders Menu
                Console.Clear();
                Console.WriteLine("Orders menu");
                Console.WriteLine("1) Check Orders");
                Console.WriteLine("2) Add new Order");
                int menuChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
                if (menuChoice == -1) continue;
                if (menuChoice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Choose one to check the status:");
                    _currentUser.PrintOrders();
                    int orderChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
                    if (menuChoice == -1) continue;
                    TextHelper.GenerateStatusMesage(_currentUser.Orders[orderChoice - 1].Status);
                    Console.ReadLine();
                }
                else if (menuChoice == 2)
                {
                    Console.Clear();
                    Order newOrder = new Order();
                    Console.WriteLine("Enter order name:");
                    newOrder.Title = Console.ReadLine();
                    Console.WriteLine("Enter order description:");
                    newOrder.Description = Console.ReadLine();
                    OrdersTempDB.InsertOrder(_currentUser.Id, newOrder);
                    Console.ReadLine();
                }
                #endregion
                #endregion
            }


            Console.ReadKey();
        }
    }
}
