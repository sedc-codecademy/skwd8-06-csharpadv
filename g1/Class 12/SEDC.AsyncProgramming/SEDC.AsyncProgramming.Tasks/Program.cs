using System;
using System.Threading;
using System.Threading.Tasks;


namespace SEDC.AsyncProgramming.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App started.");
            // Single Task
            //Task taskOne = new Task(() =>
            //{
            //    Thread.Sleep(2000);
            //    Console.WriteLine("Running after 2000 ms");
            //});

            //taskOne.Start();
            //Console.ReadLine();

            //Task<int> valueTask = new Task<int>(() =>
            //{
            //    Thread.Sleep(2000);
            //    return 3 + 3;
            //});

            //valueTask.Start();
            //Console.Write(valueTask.Result);

            for (int i = 0; i < 10; i ++)
            {
                var index = i;

                var result = Task<string>.Run(() =>
                {
                    Thread.Sleep(2000);
                    return $"Task number {index}";
                });

                Console.WriteLine(result.Result);
            }

            Console.ReadLine();
        }
    }
}
