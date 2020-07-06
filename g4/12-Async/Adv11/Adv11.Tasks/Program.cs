using System;
using System.Threading;
using System.Threading.Tasks;

namespace Adv11.Tasks
{
	class Program
	{
        static void Main(string[] args)
        {
			//Console.WriteLine("App start...");

			// Signle Task Example
			//Task myTask = new Task(() =>
			//{
			//	Thread.Sleep(2000);
			//	Console.WriteLine("Running after 2000ms");
			//});

			//myTask.Start();

			//Single task with return type Example
			Task<int> valueTask = new Task<int>(() =>
			{
				Thread.Sleep(2000);
				Console.WriteLine("We can now get the number...");
				return 6;
			});
			valueTask.Start();

			//Checking the result of a task Example
			Task.Run(() =>
			{
				Thread.Sleep(3000);
				Console.WriteLine("This is executed immedietly...");
			});
			Console.WriteLine(valueTask.Result);
			Console.WriteLine("App End...");

			// Running 20 tasks at once and see how they execute asynchronously 
			// If the numbers go from 1 to 20 then open a lot of chrome browser windows while it works or do some intensive action on the operating system
			//for (int i = 1; i <= 20; i++)
			//         {
			//             int temp = i;
			//             Task.Run(() =>
			//             {
			//                 Thread.Sleep(2000);
			//                 Console.WriteLine($"TASK NO. {temp}");
			//             });
			//         }
			Console.ReadLine();
        }
    }
}
