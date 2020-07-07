using System;
using System.Threading;
using System.Threading.Tasks;

namespace Class13.AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example for synchronous execution ( It does not show the add while we wait )
            //SendMessage("Hey there SEDC students!");

            //Example of asynchronous execution(It shoes the ad while we wait )
            var x = SendMessageAsync("Hey there SEDC students!");
            Console.WriteLine(x.Status);

            ShowAd("Potato");
            Console.ReadLine();
            Console.WriteLine(x.Status);
            Console.ReadLine();
        }


        public static void SendMessage(string message)
        {
            Console.WriteLine("Sending message...");
            Thread.Sleep(7000);
            Console.WriteLine($"The message {message} was sent!");
        }
        public static async Task SendMessageAsync(string message)
        {
            Console.WriteLine("Sending message...");
            await Task.Run(() => // for making sync with async add await here
            {
                Thread.Sleep(7000);
                Console.WriteLine($"The message {message} was sent!");
            });
        }
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
