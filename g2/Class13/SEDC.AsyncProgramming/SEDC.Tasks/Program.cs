using System;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single Task Example

            //Console.WriteLine("App start...");
            //Task myTask = new Task(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Running after 2000ms");
            //});

            //myTask.Start();

            //Task<int> valueTask = new Task<int>(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("We can now get the number...");
            //    return 6;
            //});
            //valueTask.Start();

            ////Checking the result of a task Example
            //Task.Run(() =>
            //{
            //    Thread.Sleep(3000);
            //    Console.WriteLine("This is executed immedietely...");
            //});
            //Console.WriteLine(valueTask.Result);
            //Console.WriteLine("App End...");




            // Running 20 tasks at once and see how they execute asynchronously
            // If the numbers go from 1 to 20 then open a lot of chrome browser windows or tabs
            // While it works or do some intensive action on the operating system

            //for (int i = 1; i < 20; i++)
            //{
            //    int temp = i;
            //    Task.Run(() =>
            //    {
            //        Thread.Sleep(2000);
            //        Console.WriteLine($"TASK NO. {temp}");
            //    });
            //}


            Task<string> newTask = new Task<string>(() =>
            {
                Thread.Sleep(3000);
                return "Hello there!";
            });

            Console.WriteLine("Before start: " + newTask.Status);

            newTask.Start();
            Console.WriteLine("After starting the task: " + newTask.Status);

            Thread.Sleep(2000);
            Console.WriteLine("After execution of the task: " + newTask.Status);

            if (newTask.IsCompleted)
            {
                Console.WriteLine("Task completed!");
            }
            else
            {
                Console.WriteLine("Task still running!");
            }

            Thread.Sleep(3000);
            Console.WriteLine("After execution of the task: " + newTask.Status);


            Thread.Sleep(3000);
            Console.WriteLine("After execution of the task: " + newTask.Status);


            Console.ReadLine();
        }
    }
}
