using System;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await InitialExecution();

            Console.ReadLine();
        }

        public static async Task InitialExecution()
        {
            Console.WriteLine(await SendMessage("my first message", 2000));
            Console.WriteLine(await SendMessage("my second message", 3000));

            PrintMessage("my fourth message", 2000);
            PrintMessage("my fifth message", 2000);
        }

        public static async Task<string> SendMessage(string message, int ms)
        {
            await Task.Delay(ms);
            return $"[RECEIVED] {message}";
        }

        public static async Task PrintMessage(string message, int ms)
        {
            await Task.Delay(ms);
            Console.WriteLine($"[PRINT] {message}");
        }
    }
}
