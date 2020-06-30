using System;
using System.IO;

namespace Class10.FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DirectoryManipulation

            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);



            string appPath = @"..\..\..\";
            bool myFolderExists = Directory.Exists(appPath + @"myFolder");
            bool myFolder2Exists = Directory.Exists(appPath + @"myFolder2");
            bool myFolderExistsString = Directory.Exists(@"C:\Users\Andrej.Chichakovski\FileStreamDemo\Class10.FileSystem\Class10.FileSystem");
            Console.WriteLine($"Does myFolder exists : {myFolderExists}");
            Console.WriteLine($"Does myFolder2 exists: {myFolder2Exists}");

            //Create a new folder
            string newFolder = appPath + @"newFolder";
            Console.WriteLine($"Does newFolder exists before: {Directory.Exists(newFolder)}");
            if (!Directory.Exists(newFolder))
            {
                Directory.CreateDirectory(newFolder);
                Console.WriteLine("New directory was created!");
            }

            //Delete a directory
            if (Directory.Exists(newFolder))
            {
                Directory.Delete(newFolder);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("newFolder was DELETED");
                Console.ResetColor();
            }

            #endregion

            #region FileManipulation 

            string filesPath = appPath + @"myFolder\";
            if (!Directory.Exists(filesPath))
            {
                Directory.CreateDirectory(filesPath);
                Console.WriteLine("New directory was created");
            }

            //File exists
            bool testTxtExists = File.Exists(filesPath + @"test.txt");
            bool test2TxtExists = File.Exists(filesPath + @"test2.txt");
            Console.WriteLine($"Does test.txt exists : {testTxtExists}");
            Console.WriteLine($"Does test2.txt exists: {test2TxtExists}");

            //File Create
            if (!File.Exists(filesPath + @"test.txt"))
            {
                File.Create(filesPath + @"test.txt").Close();
                Console.WriteLine("A file was created");
                
            }

            //Writing in a file
            string testTxtPath = filesPath + @"test.txt";
            if(File.Exists(testTxtPath))
            {
                File.WriteAllText(testTxtPath, "Hello SEDC! We are writing in a file");
                Console.WriteLine("Succesfully written in a file!");
            }
            //Read from a file
            if(File.Exists(testTxtPath))
            {
                string content = File.ReadAllText(testTxtPath);
                Console.WriteLine("This is the content from the file : ");
                Console.WriteLine(content);
               
            }


            Console.ReadLine();


            #endregion
        }
    }
}
