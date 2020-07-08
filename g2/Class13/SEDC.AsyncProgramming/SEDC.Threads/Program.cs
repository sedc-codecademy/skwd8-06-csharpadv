using System;
using System.Threading;

namespace SEDC.Threads
{
    class Program
    {
        //Synchronous
        public static void SendMessages()
        {
            Console.WriteLine("Getting Ready...");
            Thread.Sleep(2000);
            Console.WriteLine("First message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Second message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Third message arrived!");
            Console.WriteLine("All messages are received!");
        }

        // Asynchronous
        public static void SendMessagesWithThreads()
        {
            Console.WriteLine("Getting Ready...");

            Thread myThread = new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("First message arrived!");
            });
            myThread.Start();

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Second message arrived!");
            }).Start();

            new Thread(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("Third message arrived!");
            }).Start();

            Console.WriteLine("All messages are received!");
        }


        static void Main(string[] args)
        {
            //SendMessages();
            SendMessagesWithThreads();
            Console.ReadLine();
        }
    }
}
