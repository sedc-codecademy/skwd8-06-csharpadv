using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            #region starting stopwatch
            Stopwatch stopwatch = Stopwatch.StartNew();
            #endregion

            Console.WriteLine("Staring Tasks app");

            Task task1 = new Task(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("My first message");
            });
            task1.Start();

            Task<string> task2 = new Task<string>(() =>
            {
                Thread.Sleep(3000);
                //Console.WriteLine("My second massage");
                return "My second massage";
            });
            task2.Start();

            //while (true)
            //{
            //    if (task2.IsCompleted)
            //    {
            //        Console.WriteLine(task2.Result);
            //        break;
            //    }
            //}
            Console.WriteLine(task2.Result);

            Task.Run(() =>
            {
                Console.WriteLine("My fourth message");
            });
            


            #region stopping stopwatch
            while (true)
            {
                if (task1.IsCompleted && task2.IsCompleted)
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
