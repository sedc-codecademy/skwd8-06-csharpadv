using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._02.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }

        public User(int id, string username, string address)
        {
            Id = id;
            Username = username;
            Password = "123456";
            Address = address;
            Orders = new List<Order>();
        }
        public void PrintInfo()
        {
            Console.WriteLine($"This is {TextHelper.CapitalFirstLetter(Username)} and their password is {Password}!");
            Console.WriteLine("This is not a very secure application as you an tell. Sorry.");
        }
        public void PrintOrders()
        {
            for (int i = 0; i < Orders.Count; i++)
            {
                Console.WriteLine($"{i + 1} {Orders[i].Print()}");
            }
        }
    }
}
