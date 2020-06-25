using System;
using System.Collections.Generic;
using System.Text;

namespace Events.Entities
{
    public class Subscriber1
    {
        public void GetMessage1(string message)
        {
            Console.WriteLine("Subscriber 1 is here!!!");
            Console.WriteLine("YAY I GOT MY MESSAGE");
            Console.WriteLine($"THE MESSAGE IS: {message}");
        }
    }
}
