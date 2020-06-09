using StoreExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExample.Enteties
{
    public class Tobaco : Store, IPayWithCard
    {
        public void PayByCard()
        {
            Console.WriteLine("Paid successfully");
        }
    }
}
