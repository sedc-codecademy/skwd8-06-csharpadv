using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            if (int.TryParse(Console.ReadLine(), out int x))
            {
                var result = x.Power(2).Multiply(3).Add(1);
                //var result = PolynomGenerator.Add(PolynomGenerator.Multiply(PolynomGenerator.Power(x, 2), 3), 1);
                Console.WriteLine(result);
            }

            IEnumerable<int> nums = new List<int> { 7, 2, 3 };

            var results = nums.Select(n => n.Power(2)).Select(n => n.Multiply(3)).Select(n => n.Add(1));

            //var oddSquares = nums.Where(n => n % 2 == 1).Select(n => n * n).First();

            var oddSquares = Enumerable.First(Enumerable.Select(Enumerable.Where(nums, n => n % 2 == 1), n => n * n));

            Console.WriteLine(oddSquares);

        }
    }
}
