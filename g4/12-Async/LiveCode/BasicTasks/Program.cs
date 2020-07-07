using System;
using System.Threading;
using System.Threading.Tasks;

namespace BasicTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Run().Wait();
        }

        static async Task Run()
        {
            Calculator calc = new Calculator { First = 10, Second = 3 };

            Console.WriteLine(calc.Add());

            int slowResult = calc.SlowOperation();
            Console.WriteLine(slowResult);

            Task<int> slowResultAsyncTask = calc.SlowOperationAsync();
            Console.WriteLine("Started executing task");

            Thread.Sleep(5000);

            int slowResultAsync = await slowResultAsyncTask;
            Console.WriteLine("Finished executing task");
            Console.WriteLine(slowResultAsync);
        }
    }
}
