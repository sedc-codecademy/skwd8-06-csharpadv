using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var texts = ReadTexts();
            var query = ReadQuery();
            var result = FindInText(texts, query);

            var output = FormatResult(result);
            Console.WriteLine(output);
        }

        private static string FormatResult(FindResult result)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Found {result.Count} matches");
            var values = result.Values.ToList();
            for (int i = 0; i < values.Count; i++)
            {
                var value = values[i];
                sb.AppendLine($"#{i + 1}: {value}");
            }
            return sb.ToString();
        }

        private static FindResult FindInText(List<string> texts, string query)
        {
            var actualQuery = query.ToLower();
            var result = texts.Where(text => text.ToLower().Contains(actualQuery));
            return new FindResult
            {
                Values = result,
                Count = result.Count()
            };
        }

        private static string ReadQuery()
        {
            Console.WriteLine("Enter search text:");
            var result = Console.ReadLine();
            return result;
        }

        static List<string> ReadTexts()
        {
            const string terminator = "x";
            var texts = new List<string>();
            while (true)
            {
                Console.Write("Enter Line: ");
                var input = Console.ReadLine();
                if (input == terminator)
                {
                    break;
                }
                texts.Add(input);
            }
            return texts;
        }
    }
}
