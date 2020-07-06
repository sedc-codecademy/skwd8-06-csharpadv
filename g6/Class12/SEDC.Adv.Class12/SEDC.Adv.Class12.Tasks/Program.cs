using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.Adv.Class12.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //var stopwatch = new Stopwatch();

            //stopwatch.Start();

            ////Task myTask = new Task(() =>
            ////{
            ////    Thread.Sleep(3000);
            ////    Console.WriteLine("Success after 3000 ms");
            ////});

            ////myTask.Start();

            //Task<int> sumTask = new Task<int>(() => 
            //{
            //    Thread.Sleep(5000);
            //    Console.WriteLine("We can now get the number...");
            //    return 8;
            //});

            //sumTask.Start();

            //Console.WriteLine("Enter name: ");
            //string name = Console.ReadLine();

            //Task.Run(() =>
            //{
            //    Thread.Sleep(3000);
            //    Console.WriteLine("This is executed immedietly");
            //});

            //Console.WriteLine(name);
            //Console.WriteLine(sumTask.Result);

            //Console.WriteLine(stopwatch.Elapsed);
            //stopwatch.Stop();

            //for (int i = 1; i < 20; i++)
            //{
            //    int temp = i;
            //    Task.Run(() =>
            //    {
            //        Thread.Sleep(2000);
            //        Console.WriteLine($"TASK No. {temp}");
            //    });
            //}

            Task myTask = Task.Run(() =>
            {

            });

            Console.ReadLine();
        }
    }
}
