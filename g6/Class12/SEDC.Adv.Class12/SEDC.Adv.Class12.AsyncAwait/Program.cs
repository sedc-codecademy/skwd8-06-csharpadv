using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace SEDC.Adv.Class12.AsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            //SendMessage("Hello SEDC");

            //var sendMessageTask = SendMessageAsync("Hello SEDC");
            //Console.WriteLine("STATUS: " + sendMessageTask.Status);

            //ShowAd("Tomato");
            //Console.ReadLine();
            //Console.WriteLine("STATUS: " + sendMessageTask.Status);

            //MainThread();
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Console.WriteLine(stopWatch.Elapsed);

            var longRuningTask = LongRuningTask(3); // 3sek
            var longRuningTask1 = LongRuningTask(5); // 5sek
            // more logic here ...
            Thread.Sleep(3000); // our logic is 3 sek

            var longRuningTaskResult = longRuningTask.Result;
            var longRuningTaskResult1 = longRuningTask1.Result;
            var result = longRuningTaskResult1 + longRuningTaskResult;
            Console.WriteLine(stopWatch.Elapsed);
            stopWatch.Stop();

            //Console.WriteLine(longRuningTask);
            Console.WriteLine(result);


            Console.ReadLine();
        }

        public static async Task MainThread()
        {
            await SendMessageAsync("Hello from SEDC");
            ShowAd("Potato");
        }

        public static void SendMessage(string msg)
        {
            Console.WriteLine("Sending message...");
            Thread.Sleep(7000);
            Console.WriteLine($"The message {msg} was sent!");
        }

        public static async Task SendMessageAsync(string msg)
        {
            Console.WriteLine("Sending message...");
            await Task.Run(() =>
            {
                Thread.Sleep(7000);
                Console.WriteLine($"The message {msg} was sent!");
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
            Console.Write(" shipping worldwide ");
            Console.WriteLine();
        }

        public static async Task<int> LongRuningTask(int num)
        {
            // long runing logic...
            return await Task.Run(() =>
            {
                Thread.Sleep(num * 1000);
                return num;
            });
        }
    }
}
