using System;
using System.Diagnostics;
using System.Threading;

namespace Threads
{
    class Program
    {
        //setTimeout(() => console.log("test"), 1000);

        static void Main(string[] args)
        {
            #region starting stopwatch
            Stopwatch stopwatch = Stopwatch.StartNew();
            #endregion

            Console.WriteLine("Strarting app");


            //// Sync way of execution
            //Thread.Sleep(2000);
            //Console.WriteLine("This is my first message");

            //Thread.Sleep(3000);
            //Console.WriteLine("This is my second massage");
            //// About 5100 ms



            // Async way of execution
            Thread task1 = new Thread(() =>
            {
                Stopwatch task1Stopwatch = Stopwatch.StartNew();

                Thread.Sleep(2000);
                Console.WriteLine("This is my first message");

                task1Stopwatch.Stop();
                Console.WriteLine(task1Stopwatch.ElapsedMilliseconds);
            });
            task1.Start();

            Thread task2 = new Thread(() =>
            {
                Stopwatch task2Stopwatch = Stopwatch.StartNew();

                Thread.Sleep(3000);
                Console.WriteLine("This is my second massage");

                task2Stopwatch.Stop();
                Console.WriteLine(task2Stopwatch.ElapsedMilliseconds);
            });
            task2.Start();


            #region stopping stopwatch
            while (true)
            {
                if (!task1.IsAlive && !task2.IsAlive)
                {
                    stopwatch.Stop();
                    Console.WriteLine($"All time {stopwatch.ElapsedMilliseconds}");

                    break;
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}
