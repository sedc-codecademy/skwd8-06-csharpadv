using System;

namespace DisposePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            using var logger = new FileLogger("log.txt");
            var firstInput = Console.ReadLine();
            if (!int.TryParse(firstInput, out int first))
            {
                logger.Error($"{firstInput} is not a valid integer");
                return;
            }
            logger.Info($"Received {first} as first value");

            var secondInput = Console.ReadLine();
            if (!int.TryParse(secondInput, out int second))
            {
                logger.Error($"{secondInput} is not a valid integer");
                return;
            }
            logger.Info($"Received {second} as second value");

            try
            {
                var result = first / second;
                logger.Info($"Divided {first} by {second} and gotten {result}");
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
    }
}
