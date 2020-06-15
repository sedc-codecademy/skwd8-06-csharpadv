using System;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var generator = new NameGenerator();
            // generator.Run();

            /*
                [
                    "sadasd",
                    "sadasdas",
                       ....
                    "asdasdasD",
                    "sdadsadasd"
                ]
             
             */

            var names = generator.GenerateNames();

            //names = names.Concat(names).Concat(names);
            //names = names.Concat(names).Concat(names);
            //names = names.Concat(names).Concat(names);
            //names = names.Concat(names).Concat(names);
            //names = names.Concat(names).Concat(names);
            //names = names.Concat(names).Concat(names);
            //names = names.Concat(names).Concat(names);

            Stopwatch sw = Stopwatch.StartNew();

            //string jsonNames = "[\n";
            //foreach (var name in names)
            //{
            //    jsonNames += $"\t\"{name}\",\n";
            //}
            //jsonNames = jsonNames.Substring(0, jsonNames.Length - 2);
            //jsonNames += "\n]";

            //sw.Stop();
            //// Console.WriteLine(jsonNames);
            //Console.WriteLine(sw.ElapsedMilliseconds);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("[");
            foreach (var name in names)
            {
                sb.AppendLine($"\t\"{name}\",");
            }
            sb.Remove(sb.Length - 3, 2);
            sb.AppendLine("]");
            // Console.WriteLine(sb);
            string jsonNames = sb.ToString();

            sw.Stop();
            // Console.WriteLine(jsonNames);
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine(names.Count());



        }
    }
}
