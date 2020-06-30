using System;
using System.IO;

namespace SEDC.IO.FileStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string directoryPath = $@"{currentDirectory}\NewFolder";
            string filePath = Path.Combine(directoryPath, "NewText.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            string[] users = { "User 1", "User2", "User3" };
            
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Hola Mundo!");
                sw.Write("Number of users: ");
                sw.WriteLine(users.Length);

                Console.WriteLine("Writing complete.");
            }

            StreamWriter sw1 = new StreamWriter(filePath, true);

            sw1.WriteLine("Appending new text.");
            Console.WriteLine("Writing second time complete.");

            sw1.Close();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string firstLine = sr.ReadLine();
                string secondLine = sr.ReadLine();
                string thirdLine = sr.ReadLine();
                string fourthLine = sr.ReadLine();

                Console.WriteLine(firstLine);
                Console.WriteLine(secondLine);
                Console.WriteLine(thirdLine);

                if (fourthLine != null)
                {
                    Console.WriteLine("Fourth line is not null.");
                }
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line = "";

                while (line != null)
                {
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
    }
}
