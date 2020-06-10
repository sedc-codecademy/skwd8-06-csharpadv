using SEDC.Adv._02.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Adv._02
{
    public static class OrdersTempDB
    {
        public static int OrderId { get; set; }
        public static List<Order> Orders { get; set; }
        public static List<User> Users { get; set; }
        // Static classes can have a constructor
        // There is no access modifier before the static constructor
        // This constructor is called when the application is started
        static OrdersTempDB()
        {
            OrderId = 5;
            Orders = new List<Order>()
            {
                new Order(1, "book of books", "Best book ever", OrderStatus.Delivered),
                new Order(2, "keyboard", "Mechanical", OrderStatus.DeliveryInProgress),
                new Order(3, "Shoes", "Waterproof", OrderStatus.DeliveryInProgress),
                new Order(4, "Set of Pens", "Ordinary pens", OrderStatus.Processing),
                new Order(5, "sticky Notes", "Stickiest notes in the world", OrderStatus.CouldNotBeDelivered)
            };
            Users = new List<User>()
            {
                new User(12, "Bob22", "Bob St. 44"), // index 0
                new User(13, "JillCoolCat", "Wayne St. 109a") // index 1
            };
            // Users[0] -> First person in the list, the index
            Users[0].Orders.Add(Orders[0]); // Give the first order to bob
            Users[0].Orders.Add(Orders[1]); // Give the second order to bob
            Users[0].Orders.Add(Orders[2]); // Give the third order to bob
            Users[1].Orders.Add(Orders[3]); // Give the fourth order to jill
            Users[1].Orders.Add(Orders[4]); // Give the fifth order to jill
        }
        public static void ListUsers()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {Users[i].Username}");
            }
        }
        public static void InsertOrder(int userId, Order order)
        {
            OrderId++;
            order.Id = OrderId;
            Orders.Add(order);
            // We get the user by id with linq and then add the order to their order list
            Users.Single(x => userId == x.Id).Orders.Add(order);
            Console.WriteLine("Order successfully added!");
        }

    }
}
