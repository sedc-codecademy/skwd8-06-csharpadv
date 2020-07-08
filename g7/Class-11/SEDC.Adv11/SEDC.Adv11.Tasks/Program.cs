using System;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.Adv11.Tasks
{
	class Program
	{
		static void Main(string[] args)
		{
			//Task myTask = new Task(() =>
			//{
			//	Thread.Sleep(2000);
			//	Console.WriteLine("Message 1 received!");
			//});
			//Console.WriteLine("Status before we start the task:");
			//Console.WriteLine(myTask.Status);
			//myTask.Start();
			//Console.WriteLine("Status before we hit enter on the ReadLine:");
			//Console.WriteLine(myTask.Status);
			//new Task(() =>
			//{
			//	Thread.Sleep(2000);
			//	Console.WriteLine("Message 2 received!");
			//}).Start();
			//Console.ReadLine();
			//Console.WriteLine("Status after we hit enter on the ReadLine:");
			//Console.WriteLine(myTask.Status);
			//Console.ReadLine();


			//Task<int> valueTask = new Task<int>(() =>
			//{
			//	Thread.Sleep(2000);
			//	Console.WriteLine("Message 3 received!");
			//	return 3;
			//});
			//valueTask.Start();
			//Console.WriteLine(valueTask.Result);
			//Console.ReadLine();

			for (int i = 1; i <= 20; i++)
			{
				int temp = i;
				Task.Run(() =>
				{
					Thread.Sleep(2000);
					Console.WriteLine($"Task No. {temp}");
				});
			}
			Console.ReadLine();
		}
	}
}
