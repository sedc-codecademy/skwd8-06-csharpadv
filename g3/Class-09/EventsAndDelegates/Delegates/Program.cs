using System;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop west = new Shop();
            west.InformCustomers.Invoke();

            Func<int, string> funcs;

            funcs = x => 
            {
                Console.WriteLine($"This is from the first lambda {x}");
                return x.ToString();
            };

            funcs += y =>
            {
                Console.WriteLine($"This is from the second lambda {y}");
                return y.ToString();
            };

            funcs(1);

            Console.ReadKey();
        }
    }
}
