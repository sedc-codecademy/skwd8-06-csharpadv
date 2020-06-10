using SEDC.Adv._02.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._02
{
    public static class OrdersTempDB
    {
        public static List<Order> Orders { get; set; }
        public static List<User> Users { get; set; }
        // Static classes can have a constructor
        // There is no access modifier before the static constructor
        // This constructor is called when the application is started
        static OrdersTempDB()
        {
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
                new User(12, "Bob22", "Bob St. 44"),
                new User(13, "JillCoolCat", "Wayne St. 109a")
            };
            Users[0].Orders.Add(Orders[0]);
            Users[0].Orders.Add(Orders[1]);
            Users[0].Orders.Add(Orders[2]);
            Users[1].Orders.Add(Orders[3]);
            Users[1].Orders.Add(Orders[4]);
        }

    }
}
