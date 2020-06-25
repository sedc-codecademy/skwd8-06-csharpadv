using System;

namespace Recap
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, double> func = x => x * 2.1;
            Console.WriteLine(func(2));
            Console.WriteLine(Func(2));

            Console.WriteLine(Multiply(2, num => num * 23));
            Console.WriteLine(Multiply(2, num => num * 50));

            var multiplyByTwo = MultiplyBy(2);
            var multiplyByThree = MultiplyBy(3);

            Console.WriteLine(multiplyByTwo(10));
            Console.WriteLine(multiplyByTwo(12));
            Console.WriteLine(multiplyByThree(231));

            Console.ReadKey();
        }

        private static double Func(int num)
        {
            return num * 2.1;
        }

        private static double Multiply(int num, Func<int, double> operation)
        {
            return operation(num);
        }

        private static Func<int, double> MultiplyBy(int num)
        {
            return new Func<int, double>(x => x * num);
        }
    }
}
