using SEDC.Class04.Adv.StaticClassees.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.Class04.Adv.StaticClassees
{
    public static class OrdersTempDB
    {
        public static int orderId = 5;

        public static List<User> Users;
        public static List<Order> Orders;

        static OrdersTempDB()
        {
			Orders = new List<Order>()
			{
				new Order(1, "book of books", "Best book ever", OrderStatus.Delivered),
				new Order(2, "keyboard", "Mechanical", OrderStatus.DeliveryInProgress),
				new Order(3, "Shoes", "Waterproof", OrderStatus.DeliveryInProgress),
				new Order(4, "Set of Pens", "Ordinary pens", OrderStatus.Processing),
				new Order(5, "sticky Notes", "Stickiest notes in the world", OrderStatus.CouldNotDeliver)
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

		public static void ListUsers()
		{
			//foreach (var user in Users)
			//{
			//	Console.WriteLine($"{user.Id} {user.Username}");
			//}
			for (int i = 1; i <= Users.Count; i++)
			{
				Console.WriteLine($"{i}) {Users[i - 1].Username}");
			}
		}

		public static void InsertOrder(int userId, Order order)
		{
			order.Id = ++orderId;
			Orders.Add(order);

			var user = Users.FirstOrDefault(user => user.Id == userId);
			user.Orders.Add(order);

			// Users.Single(user => user.Id == userId).Orders.Add(order);
			Console.WriteLine("Order successfuly added!");
		}
    }
}
