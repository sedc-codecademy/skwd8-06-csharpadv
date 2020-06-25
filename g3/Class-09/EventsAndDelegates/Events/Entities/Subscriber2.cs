using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Entities
{
    public class Subscriber2
    {
        public void GetMessage2(string message)
        {
            Console.WriteLine("Subscriber 2 is here!!!");
            Console.WriteLine("I DONT LIKE THE MESSAGE");
            Console.WriteLine($"THE MESSAGE IS: {message}");
        }
    }
}
