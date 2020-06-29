using System;
using System.IO;
using System.Linq;

namespace FileStreamer
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = @"D:\SWeko\Books\Calibre\Jack London\Complete Works of Jack London (2151)\Complete Works of Jack London - Jack London.txt";

            Console.WriteLine("Begin reading");
            var contents = File.ReadAllLines(filename);
            Console.WriteLine($"Total lines: {contents.Length}");
            Console.WriteLine($"Total characters: {contents.Sum(line => line.Length)}");
            Console.WriteLine("Finished reading");
        }
    }
}
