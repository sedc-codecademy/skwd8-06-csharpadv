using System;
using System.Collections.Generic;
using System.Text;

namespace Memories
{
    class StackDemo
    {
        public int One (int first, int second)
        {
            Console.WriteLine("One started");
            var result = Two(first, second) + 1;
            Console.WriteLine("One finished");
            return result;
        }

        private int Two(int first, int second)
        {
            Console.WriteLine("  Two started");
            var result = Three(first, second) + 2;
            Console.WriteLine("  Two finished");
            return result;
        }

        private int Three(int first, int second)
        {
            Console.WriteLine("    Three started");
            var result = Four(first, second) + 3;
            Console.WriteLine("    Three finished");
            return result;
        }

        private int Four(int first, int second)
        {
            Console.WriteLine("      Four started");
            var result = first * second + 4;
            Console.WriteLine("      Four finished");
            return result;
        }
    }
}
