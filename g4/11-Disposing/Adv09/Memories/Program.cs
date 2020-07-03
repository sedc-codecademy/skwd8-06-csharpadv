using System;

namespace Memories
{
    class Program
    {
        static void Main(string[] args)
        {
            var sd = new StackDemo();
            sd = new StackDemo();

            var result = sd.One(1, 2);
            Console.WriteLine(result);
        }
    }
}
