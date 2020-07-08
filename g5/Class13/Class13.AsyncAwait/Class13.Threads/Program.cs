using System;
using System.Threading;

namespace Class13.Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ReadLine();
            //Console.WriteLine("Hello World");

            //new Thread(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("This is a new thread 1.");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("This is a new thread 2.");
            //}).Start();

            //new Thread(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("This is a new thread 3.");
            //}).Start();

            //SendMessages();
            SendMessagesWithThreads();
            Console.ReadLine();
        }

        public static void SendMessages()
        {
            Console.WriteLine("Getting Ready..");
            Thread.Sleep(2000);
            Console.WriteLine("First message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Second message arrived");
            Thread.Sleep(2000);
            Console.WriteLine("Third message arrived..");
            Console.WriteLine("All messages are received!");
            Console.ReadLine();
        }

        // asynchronous
        public static void SendMessagesWithThreads()
        {
            Console.WriteLine("Getting Ready..");
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
            Console.ReadLine();
        }
    }
}
