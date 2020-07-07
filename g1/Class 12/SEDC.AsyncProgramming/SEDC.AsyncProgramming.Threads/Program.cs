using System;
using System.Threading;

namespace SEDC.AsyncProgramming.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintMessages();
            PrintMessagesWithThreads();
        }

        public static void PrintMessages()
        {
            Console.WriteLine("Get Ready.");
            Thread.Sleep(2000);
            Console.WriteLine("First message.");
            Thread.Sleep(2000);
            Console.WriteLine("Second message.");
            Console.ReadLine();
        }

        public static void PrintMessagesWithThreads()
        {
            Console.WriteLine("Get Ready.");
            
            Thread threadOne = new Thread(() => {
                Thread.Sleep(2000);
                Console.WriteLine("First message.");
            });

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Second message.");
            }).Start();

            Thread.Sleep(1000);
            threadOne.Start();
            Console.ReadLine();
        }
    }
}
