using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class09.Delegates
{
    public class Example
    {
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to events and delegates");
        }

        public void PrintMessage(string message, string name)
        {
            Console.WriteLine($"{message} : {name}");
        }

        public int SumOfTwoNumbers(int broj, int broj1)
        {
            // complex logic here ...
            return broj + broj1;
        }
    }
}
