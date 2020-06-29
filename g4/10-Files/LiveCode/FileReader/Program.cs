using System;
using System.IO;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = @"out.txt";
            if (File.Exists(filename))
            {
                var contents = File.ReadAllLines(filename);
                File.Delete(filename);
                foreach (var line in contents)
                {
                    Console.WriteLine($">> {line} <<");
                }

            }
            else
            {
                string[] contents = { "One", "Two", "Three", "Four", "Five" };
                File.WriteAllLines(filename, contents);
                Console.WriteLine("Written file");
            }
            
        }
    }
}
