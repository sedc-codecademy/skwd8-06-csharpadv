using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.StaticClassesAndPolymorphism.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }

        public User(int id, string username, string address)
        {
            this.Id = id;
            this.Username = username;
            this.Address = address;
            this.Orders = new List<Order>(); 
        }

        public void PrintUserOrders()
        {
            int i = 1;
            foreach (var order in Orders)
            {
                Console.WriteLine($"{i}. {order.Print()}");
                i++;
            }
        }
    }
}
