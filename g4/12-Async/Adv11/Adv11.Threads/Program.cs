﻿using System;
using System.Threading;

namespace Adv11.Threads
{
	class Program
	{
        static void Main(string[] args)
        {
            //SendMessages();
            SendMessagesWithThreads();
        }

        // Synchronous
        public static void SendMessages()
        {
            Console.WriteLine("Getting Ready...");
            Thread.Sleep(2000);
            Console.WriteLine("First message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Second message arrived!");
            Thread.Sleep(2000);
            Console.WriteLine("Third message arrived!");
            Console.WriteLine("All messages are recieved!");
            Console.ReadLine();
        }

        // Asynchronous
        public static void SendMessagesWithThreads()
        {
            Console.WriteLine("Getting Ready...");
            Thread myThread = new Thread(() => {
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
            Console.WriteLine("All messages are recieved!");
            Console.ReadLine();
        }
    }
}
