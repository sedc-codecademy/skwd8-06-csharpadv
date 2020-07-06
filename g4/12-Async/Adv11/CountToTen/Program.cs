using System;
using System.Threading;

namespace CountToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Thread thread = new Thread(() => WriteNumber(i));
                thread.Start();
            };
        }

        static void WriteNumber(int number)
        {
            //Console.WriteLine(number);
            //Console.WriteLine($"{number} on thread {Thread.CurrentThread.ManagedThreadId}");
            Console.WriteLine($"{number} on thread {Thread.CurrentThread.ManagedThreadId} on processor {Thread.GetCurrentProcessorId()}");
        }
    }
}
