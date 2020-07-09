using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace FileHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter five words:");
            List<string> userChoise = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Word {i+1}: ");
                userChoise.Add(Console.ReadLine());
            }

            // Start the HandleFileAsync method
            Task<int> task = HandleFileAsync(userChoise);

            Console.WriteLine("Please wait patiently while file is processing");

            // Do something at same time as the file is being created and read
            //Console.WriteLine("Please enter something while file is processing");
            //string userInput = Console.ReadLine();
            //Console.WriteLine($"You entered (asynchronious): {userInput}");
            var result = task.Result;
            Console.WriteLine($"Count: {result}");
            Console.WriteLine("[DONE]");
            // Console.ReadLine();
        }

        static async Task<int> HandleFileAsync(List<string> textList)
        {
            Console.WriteLine("----- Start Working on file ------");
            string currentDirectory = Directory.GetCurrentDirectory();
            string directoryPath = Path.Combine(currentDirectory, "FileSystem");
            string filePath = Path.Combine(directoryPath, "OurFile.txt");

            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var str in textList)
                {
                    sw.Write(str);
                }
            }

            int count = 0;
            using (StreamReader sr = new StreamReader(filePath))
            {
                Thread.Sleep(3000);
                string text = await sr.ReadToEndAsync();
                count += text.Length;
            }

            Console.WriteLine("------- File exit --------");
            return count;
        }
    }
}
