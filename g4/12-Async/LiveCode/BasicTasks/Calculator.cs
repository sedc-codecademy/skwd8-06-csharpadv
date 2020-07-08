using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BasicTasks
{
    class Calculator
    {
        public int First { get; set; }
        public int Second { get; set; }

        public int Add()
        {
            return First + Second;
        }

        public int SlowOperation()
        {
            Thread.Sleep(2000);
            return First + Second;
        }

        public async Task<int> SlowOperationAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(200);
                Console.Write($"delaying");
                for (int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
                Console.CursorTop -= 1;
            }
            return First * Second;
        }
    }
}
