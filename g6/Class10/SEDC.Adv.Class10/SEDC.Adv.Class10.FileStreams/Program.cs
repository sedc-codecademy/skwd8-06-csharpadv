using System;
using System.IO;

namespace SEDC.Adv.Class10.FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileFolder = "./" + @"testFolderCreatedFromC#\";
            string filePath = fileFolder + "test.txt";

            if (!Directory.Exists(fileFolder))
            {
                Directory.CreateDirectory(fileFolder);
                Console.WriteLine("Folder is created");
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                Console.WriteLine("New file was created");
            }

            // Writing with stream writer
            // open stream writer
            StreamWriter sw1 = new StreamWriter(filePath);
            sw1.WriteLine("Hello SEDC!");
            sw1.WriteLine("We are writing from StreamWriter!");
            Console.WriteLine("Writing is complete");
            // close stream writer
            sw1.Close();

            Console.ReadLine();

            // Writing with stream writer in using statement
            using (StreamWriter swUsing = new StreamWriter(filePath))
            {
                swUsing.WriteLine("Hello from using statement");
                Console.WriteLine("Writing is complete in using statement");
            }

            // Writing with stream writer without rewriting the previous text
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Hello Again");
                sw.WriteLine("This is written on top of the previous one!");
                Console.WriteLine("Writing again!");
            }

            // Reading with StreamReader
            using (StreamReader sr = new StreamReader(filePath))
            {
                string firstLine = sr.ReadLine();
                string secondLine = sr.ReadLine();
                string restOfTheFile = sr.ReadToEnd();
                Console.WriteLine($"First line: {firstLine}");
                Console.WriteLine($"Second line: {secondLine}");
                Console.WriteLine($"Rest of the file: {restOfTheFile}");
            }

            // set position of cursor and read from there
            using (StreamReader sr = new StreamReader(filePath))
            {
                // setting the position of the cursor
                sr.BaseStream.Position = 49;
                string restOfTheFile = sr.ReadToEnd();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Rest of the file: {restOfTheFile}");
            }

            Console.ReadLine();
        }
    }
}
