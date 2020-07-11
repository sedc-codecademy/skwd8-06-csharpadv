using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SEDC.Adv.Class13.SB
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Repeat("abcdefg", 80000);
            Console.WriteLine(data.Count());

            Stopwatch stopwatch = Stopwatch.StartNew();

            Console.WriteLine("Using concatenation");
            var result = string.Empty;
            foreach (var word in data)
            {
                result += word;
            }

            stopwatch.Stop();
            Console.WriteLine(result.Length);
            Console.WriteLine("Duration: {0} ms", stopwatch.ElapsedMilliseconds);

            Console.WriteLine("Using string builder");
            stopwatch = Stopwatch.StartNew();
            
            var result2 = new StringBuilder();
            foreach (var word in data)
            {
                result2.Append(word);
            }

            stopwatch.Stop();
            var stringResult = result2.ToString();
            Console.WriteLine(stringResult.Length);
            Console.WriteLine("Duration: {0} ms", stopwatch.ElapsedMilliseconds);

            Console.ReadLine();
        }
    }
}
