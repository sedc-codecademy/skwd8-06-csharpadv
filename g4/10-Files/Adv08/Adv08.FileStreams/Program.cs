using System;
using System.IO;

namespace Adv08.FileStreams
{
	class Program
	{
		static void Main(string[] args)
		{
            string appPath = @"..\..\..\";
            string folderPath = appPath + @"myFolder\";
            string filePath = folderPath + @"test.txt";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("New directory was created!");
            }
            #region FileManipulation - Stream


            // Writing with StreamWriter
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hello SEDC!");
                sw.WriteLine("We are writing text from StreamWriter!");
                Console.WriteLine("Writing is complete!");
            }

            // Writing without rewriting the document with StreamWriter
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine("Hello AGAIN!");
                sw.WriteLine("This is written on top of the previous one!");
                Console.WriteLine("Writing again!");
            }
            Console.ReadLine();

            // Reading with StreamReader
            using (StreamReader sr = new StreamReader(filePath))
            {
                string firstLine = sr.ReadLine();
                string secondLine = sr.ReadLine();
                string restContent = sr.ReadToEnd();
                Console.WriteLine($"First Line:{firstLine}");
                Console.WriteLine($"Second Line:{secondLine}");
                Console.WriteLine($"Rest of content:{restContent}");
            }
            Console.ReadLine();
            #endregion
        }
    }
}
