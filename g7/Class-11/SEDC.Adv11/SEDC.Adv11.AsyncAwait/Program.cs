using System;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.Adv11.AsyncAwait
{
	class Program
	{
		static void Main(string[] args)
		{
			// This is not what we expected and it is not the correct implementation because we wait 7 seconds and then we see the ad
			//SendMessage();
			//ShowAd("Potato");

			// This is the correct implementation because we send the message and while we wait we show an ad
			SendMessageAsync();
			ShowAd("Potato");
			Console.ReadLine();
		}

		// Async methods MUST ALWAYS RETURN TASK
		// If the method is void then we write just Task
		// If the method has a value we write Task<value type>
		// You can't use await outside of an async method
		public static async Task SendMessageAsync()
		{
			Console.WriteLine("Sending a message...");
			// Not await
			// Not await
			// Await
			// not await
			// await
			await Task.Run(() =>
			{
				Thread.Sleep(7000);
				Console.WriteLine("The message was sent!");
			});
		}

		// This method takes time
		// Because it takes time it needs to be asynchronous
		public static void SendMessage()
		{
			Console.WriteLine("Sending a message...");
			Thread.Sleep(7000);
			Console.WriteLine("The message was sent!");
		}
		
		// This method does not take much time so its synchronous
		// We want to run this method while the user waits on the SendMessage method
		public static void ShowAd(string product)
		{
			Console.WriteLine("While you wait let us show you an ad:");
			Console.Write("Buy the best product in the world ");
			Console.ForegroundColor = ConsoleColor.DarkCyan;
			Console.Write(product);
			Console.ResetColor();
			Console.Write(" now and get ");
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("FREE");
			Console.ResetColor();
			Console.WriteLine(" shipping worldwide!");
			Console.ReadLine();
		}
	}
}
