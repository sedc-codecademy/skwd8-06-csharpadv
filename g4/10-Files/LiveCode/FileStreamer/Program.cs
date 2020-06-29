using System;
using System.IO;
using System.Linq;

namespace FileStreamer
{
    class Program
    {
        static void Main(string[] args)
        {
            //var filename = "larger-text.txt";
            //Console.WriteLine("Begin reading");
            //var contents = File.ReadAllLines(filename).Take(3);
            //Console.WriteLine($"Total lines: {contents.Count()}");
            //Console.WriteLine($"Total characters: {contents.Sum(line => line.Length)}");
            //Console.WriteLine("Finished reading");

            var filename = @"largeText.txt";
            var fileout = @"larger-text.txt";
            Console.WriteLine("Begin reading");
            var reader = new StreamReader(filename);
            //var writer = new StreamWriter(fileout, true);
            var line = reader.ReadLine();
            int totalLines = 0;
            int totalChars = 0;
            while (line != null)
            {
                totalLines += 1;
                totalChars += line.Length;
                line = reader.ReadLine();
                //writer.WriteLine(line);
                //writer.WriteLine(line);
                //writer.WriteLine(line);
                if (totalLines == 3)
                {
                    break;
                }
            }
            Console.WriteLine($"Total lines: {totalLines}");
            Console.WriteLine($"Total characters: {totalChars}");
            reader.Close();
            //writer.Close();
            Console.WriteLine("Finished reading");

        }
    }
}
