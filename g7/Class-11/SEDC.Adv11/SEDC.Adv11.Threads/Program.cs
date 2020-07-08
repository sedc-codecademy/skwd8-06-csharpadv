using System;
using System.Threading;

namespace SEDC.Adv11.Threads
{
	class Program
	{
		static void Main(string[] args)
		{ 
			// Comment and uncomment the methods to see sync and async exeution
			//SendMessages();
			SendMessagesWithThreads();
		}

		// Synchronous method
		public static void SendMessages()
		{
			Console.WriteLine("Getting ready...");
			Thread.Sleep(2000); // It will wait for 2 seconds ( We are simulating that some job takes 2 seconds to complete )
			Console.WriteLine("First message arrived");
			Thread.Sleep(2000); // It will wait for 2 seconds ( We are simulating that some job takes 2 seconds to complete )
			Console.WriteLine("Second message arrived");
			Thread.Sleep(2000); // It will wait for 2 seconds ( We are simulating that some job takes 2 seconds to complete )
			Console.WriteLine("Third message arrived");
			Console.ReadLine();
		}

		// Asynchronous method
		public static void SendMessagesWithThreads()
		{
			Console.WriteLine("Getting ready...");
			// Example of creating a thread in a variable and then starting it
			Thread myThread = new Thread(() => 
			{
				Thread.Sleep(2000); // It will wait for 2 seconds ( We are simulating that some job takes 2 seconds to complete )
				Console.WriteLine("First message arrived");
			});
			myThread.Start(); // We must start the thread in order to do the job we asked it to

			// Example of creating a thread at the spot and starting it right away
			new Thread(()=>
			{
				Thread.Sleep(2000); // It will wait for 2 seconds ( We are simulating that some job takes 2 seconds to complete )
				Console.WriteLine("Second message arrived");
			}).Start();

			new Thread(() =>
			{
				Thread.Sleep(2000); // It will wait for 2 seconds ( We are simulating that some job takes 2 seconds to complete )
				Console.WriteLine("Third message arrived");
			}).Start();



			Console.ReadLine();
		}
	}
}
