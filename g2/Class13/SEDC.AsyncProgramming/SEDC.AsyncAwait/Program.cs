using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.AsyncAwait
{
    class Program
    {

        public static void SendMessage(string message)
        {
            Console.WriteLine("Sending message...");
            Thread.Sleep(7000);
            Console.WriteLine($"The message {message} was sent!");
        }

        public static async Task SendMessageAsync(string message)
        {
            Console.WriteLine("Sending message...");
            await Task.Run(() =>
            {
                Thread.Sleep(10000);
                Console.WriteLine($"The message {message} was sent!");
            });
        }

        public static void ShowAd(string product)
        {
            Console.WriteLine("While you wait let us show you an ad:");
            Thread.Sleep(1000);

            Console.WriteLine("Buy the best product in the wolrd!");
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Thread.Sleep(1000);
            Console.WriteLine(product);
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine(" now and get ");
            Console.ForegroundColor = ConsoleColor.Green;

            Thread.Sleep(1000);
            Console.WriteLine("FREE");
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine(" shipping worldwide!");
        }


        public static async Task MainThread()
        {
            await SendMessageAsync("Hey there I am an async call!");
            ShowAd("Potato");
        }

        public static async Task<string> GetData(string url)
        {
            await Task.Run(() =>
            {
                return url;
            });
            return url;
        }

        static void Main(string[] args)
        {
            //Example of Synchronous execution ( It does not show the message while we wait)
            //SendMessage("Hey there SEDC students!");

            //Example of asynchronous execution ( It shows the message while we wait)
            //Task result = SendMessageAsync("Hello there I am an async call!");
            //Console.WriteLine(result.Status);

            //Thread.Sleep(2000);
            //ShowAd("Potato");
            //Console.WriteLine(result.Status);

            // Making sync with async ?!?
            MainThread();




            Console.ReadLine();
        }
    }
}
