using System;
using System.IO;

namespace SEDC.FileSystem.StreamReadWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            string appPath = @"..\..\..\";
            string folderPath = appPath + @"StreamReaderAndWriter";
            string filePath = folderPath + @"\StremReadAndWrite.txt";


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Folder creadet!");
            }

            //Writing in a file usign StreamWriter
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hello SEDC!");
                sw.WriteLine("We are learning how to write in a file!");
                Console.WriteLine("Writing is completed!");
            }
            
            //Writing without rewriting the document with StreamWriter
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Hello AGAIN!");
                sw.WriteLine("This is written on top of the previous one!");
                Console.WriteLine("Writing again!");
            }


            //Reading from a file
            using (StreamReader sr = new StreamReader(filePath))
            {
                string firsLine = sr.ReadLine();
                string secondLine = sr.ReadLine();
                string thirdLine = sr.ReadLine();

                string restContent = sr.ReadToEnd();

                Console.WriteLine($"First line: {firsLine}");
                Console.WriteLine($"Second line: {secondLine}");
                Console.WriteLine($"Third line: {thirdLine}");

                Console.WriteLine($"Rest content: {restContent}");

            }


            Console.ReadLine();
        }
    }
}
