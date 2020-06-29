using System;
using System.IO;

namespace Adv08.FileSystem
{
	class Program
	{
		static void Main(string[] args)
		{
            #region DirectoryManipulation
            // Check what folder is your application
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);

            // Relative path to our application folder
            string appPath = @"..\..\..\";
            // Absolute path to our application folder
            // string appPath = @"C:\Users\DraganGelevski\source\repos\Adv08\Adv08.FileSystem";

            // Check if a folder exists
            bool myFolderExists = Directory.Exists(appPath + @"myFolder");
            bool myFolderExistsString = Directory.Exists(@"C:\Users\DraganGelevski\source\repos\Adv08\Adv08.FileSystem\myFolder");
            bool myFolder2Exists = Directory.Exists(appPath + @"myFolder2");
            Console.WriteLine($"Does myFolder exists: {myFolderExists}");
            Console.WriteLine($"Does myFolder2 exists: {myFolder2Exists}");

            // Create a new folder
            string newFolder = appPath + @"newFolder";
            Console.WriteLine($"Does newFolder exists before: {Directory.Exists(newFolder)}");
            if (!Directory.Exists(newFolder))
            {
                Directory.CreateDirectory(newFolder);
                Console.WriteLine("New directory was created!");
            }
            Console.WriteLine($"Does newFolder exists after: {Directory.Exists(newFolder)}");

            Console.WriteLine("Press anything to delete newFolder...");
            Console.ReadLine();

            // Delete a directory
            if (Directory.Exists(newFolder))
            {
                Directory.Delete(newFolder);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("newFolder was DELETED!");
                Console.ResetColor();
            }
            Console.ReadLine();
            #endregion
            #region FileManipulation - File
            string filesPath = appPath + @"myFolder\"; ;
            if (!Directory.Exists(filesPath))
            {
                Directory.CreateDirectory(filesPath);
                Console.WriteLine("New directory was created!");
            }

            // File exists
            bool testTxtExists = File.Exists(filesPath + @"test.txt");
            bool test2TxtExists = File.Exists(filesPath + @"test2.txt");
            Console.WriteLine($"Does test.txt exists: {testTxtExists}");
            Console.WriteLine($"Does test2.txt exists: {test2TxtExists}");

            // File Create
            if (!File.Exists(filesPath + @"test.txt"))
            {
                File.Create(filesPath + @"test.txt").Close();
                Console.WriteLine("A file was created!");
            }

			//Console.WriteLine("To delete this file press anything...");
			//Console.ReadLine();

			//// File Delete
			//if (File.Exists(filesPath + @"\test.txt"))
			//{
			//	File.Delete(filesPath + @"\test.txt");
			//	Console.WriteLine("A file was deleted!");
			//}
			//Console.ReadLine();

			// Writing in a file
			string testTxtPath = filesPath + @"test.txt";
            if (File.Exists(testTxtPath))
            {
                File.WriteAllText(testTxtPath, "Hello SEDC! We are writing in a file");
                Console.WriteLine("Successfully written in a file!");
            }
            Console.ReadLine();

            if (File.Exists(testTxtPath))
            {
                File.WriteAllText(testTxtPath, "Hello SEDC! We are writing in a file");
                Console.WriteLine("Successfully written in a file!");
            }
            Console.ReadLine();

            // Read from a file
            if (File.Exists(testTxtPath))
            {
                string content = File.ReadAllText(testTxtPath);
                Console.WriteLine("This is the text:");
                Console.WriteLine(content);
            }
            Console.ReadLine();
            #endregion
        }
    }
}
