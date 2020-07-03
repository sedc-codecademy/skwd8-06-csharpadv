using System;
using System.Collections.Generic;
using System.IO;

namespace ReadingFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;

            //var writer = new StreamWriter2("input.txt");
            //try
            //{
            //    while (input != "x")
            //    {
            //        input = Console.ReadLine();
            //        writer.WriteLine(input);
            //        if (input == "y")
            //        {
            //            throw new Exception("Se srina...");
            //        }
            //    }
            //    // writer.Close();
            //}
            ////catch (Exception ex)
            ////{
            ////    Console.WriteLine($"Something went wrong: {ex.Message}");
            ////    // writer.Close();
            ////}
            //finally
            //{
            //    writer.Close();
            //}

            using (var writer = new StreamWriter2("input.txt"))
            {
                while (input != "x")
                {
                    input = Console.ReadLine();
                    writer.WriteLine(input);
                    if (input == "y")
                    {
                        throw new Exception("Se srina...");
                    }
                }
            }

            Console.ReadLine();
        }

        static void Print<T>(IEnumerable<T> source)
        {
            foreach (var item in source)
            {
                Console.WriteLine(item);
            }
        }
    }
}
