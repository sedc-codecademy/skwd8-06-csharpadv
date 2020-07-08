using System;
using System.Diagnostics;
using System.Threading;

namespace SEDC.Adv.Class12.Sync
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            // long runing tasks

            LongRunningTaskOne();
            LongRunningTaskTwo();
            LongRunningTaskThree();

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();

            Console.WriteLine(name);
            // --

            Console.WriteLine(stopwatch.Elapsed);
            stopwatch.Stop();
            Console.ReadLine();
        }

        public static void LongRunningTaskOne()
        {
            Thread.Sleep(10000);
            Console.WriteLine("Task one complete");
        }

        public static void LongRunningTaskTwo()
        {
            Thread.Sleep(7000);
            Console.WriteLine("Task two complete");
        }

        public static void LongRunningTaskThree()
        {
            Thread.Sleep(4000);
            Console.WriteLine("Task three complete");
        }
    }
}
