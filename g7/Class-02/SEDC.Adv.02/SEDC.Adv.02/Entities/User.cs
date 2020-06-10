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
        public void PrintInfo()
        {
            Console.WriteLine($"This is {TextHelper.CapitalFirstLetter(Username)} and their password is {Password}!");
            Console.WriteLine("This is not a very secure application as you an tell. Sorry.");
        }
    }
}
