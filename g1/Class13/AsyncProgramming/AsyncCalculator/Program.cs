using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // var result = CalculateAsync().Result;
            //CalculateThree(result);
            var result = CalculateAsync();
            var res = result.GetAwaiter();
            res.OnCompleted(() =>
            {
                Console.WriteLine("ASD");
            });

            Console.ReadLine();
        }

        //public static async void GrandParent()
        //{
        //    await CalculateAsync();
        //}

        //public static async Task<int> CalculateAsync()
        //{
        //    var result = await Task.Run(() =>
        //    {
        //        return CalculateOne();
        //    });

        //    return CalculateTwo(result);
        //}

        public static async Task CalculateAsync()
        {
            var result = await Task.Run(() =>
            {
                return CalculateOne();
            });

            CalculateTwo(result);
        }

        public static int CalculateOne()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Calculating in method 1");
            return 100;
        }

        public static int CalculateTwo(int number)
        {
            Console.WriteLine($"Calculating in method 2 with {number}");
            return 200;
        }

        public static int CalculateThree(int number)
        {
            Console.WriteLine("Calculating in method 3");
            return 300;
        }
    }
}
