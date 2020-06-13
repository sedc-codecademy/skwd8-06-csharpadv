using SEDC.StaticClassesAndPolymorphism.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.StaticClassesAndPolymorphism.DB
{
    //This static class is serving as a temporary database
    //While the app is running, the static members of this class will keep their data
    //It can also be accessed anywhere
    public static class OrdersTmpDB
    {
        public static int orderId = 3;

        public static List<User> Users;

        public static List<Order> Orders;

        static OrdersTmpDB()
        {
            Orders = new List<Order>
            {
                new Order(1, "harry Potter book", "Best book ever", OrderStatus.Fullfiled),
                new Order(2, "PC headset", "Best headest ever", OrderStatus.DeliveryInProgress),
                new Order(3, "Lenovo laptop", "Best laptop ever", OrderStatus.Processing),
            };

            Users = new List<User>
            {
                new User(1, "martinpano", "Test address 1"),
                new User(2, "dejanjovanov", "Test address 2")
            };

            Users.First().Orders.Add(Orders[0]);
            Users.First().Orders.Add(Orders[1]);
            Users.Last().Orders.Add(Orders[2]);
        }

        public static void ListUsers()
        {
            int i = 1;
            foreach (var user in Users)
            {
                Console.WriteLine($"{i}. {user.Username}");
                i++;
            }
        }

        public static void InsertOrder(int userId, Order order)
        {
            order.Id = ++orderId;
            Orders.Add(order);
            Users.SingleOrDefault(x => x.Id == userId).Orders.Add(order);
            Console.WriteLine("Order successfully added!");
        }
    }
}
