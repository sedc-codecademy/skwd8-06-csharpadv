using System;
using System.IO;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var basedir = @"C:\Source\SEDC\skwd8-06-csharpadv";
            var groupDir = @".\g4\";
            var classDir = "10-Files";

            var filename = @"out.txt";

            Console.WriteLine(basedir + groupDir + "\\"+  classDir + "\\"+ filename);
            Console.WriteLine(Path.Combine(basedir, groupDir, classDir, filename));

            Console.WriteLine(Path.GetFullPath(filename));

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
