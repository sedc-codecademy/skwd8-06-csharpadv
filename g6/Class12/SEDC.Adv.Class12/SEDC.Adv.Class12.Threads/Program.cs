using System;
using System.Diagnostics;
using System.Threading;

namespace SEDC.Adv.Class12.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //var stopwatch = new Stopwatch();

            //stopwatch.Start();

            // long runing tasks

            //Thread myThread = new Thread(() =>
            //{
            //    Thread.Sleep(10000);
            //    Console.WriteLine("Task one complete");
            //});
            //myThread.Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(7000);
            //    Console.WriteLine("Task two complete");
            //}).Start();

            //new Thread(LongRunningTaskThree).Start();

            //Console.WriteLine("Enter name: ");
            //string name = Console.ReadLine();

            //Console.WriteLine(name);
            // --

            //Console.WriteLine(stopwatch.Elapsed);
            //stopwatch.Stop();


            // get value from thread

            int val = 0;

            var myThread = new Thread(() => 
            {
                Thread.Sleep(20000);
                val = 10;
            });
            myThread.Start();

            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Before join");
            Console.WriteLine(val);
            Console.WriteLine(name);

            myThread.Join(); // with join we await excution of other thread
            Console.WriteLine("After join");
            Console.WriteLine(val);

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
