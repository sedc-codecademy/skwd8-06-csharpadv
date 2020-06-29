using System;
using System.IO;

namespace SEDC.Adv.Class10.FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // absolute path to project folder
            string absoluthPath = @"C:\SEDC\SEDC08\c#Advanced\skwd8-06-csharpadv\g6\Class10\SEDC.Adv.Class10\SEDC.Adv.Class10.FileSystem\";

            // relative path
            string relativePath = @"./";

            var currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectory);


            #region Create delete folder
            bool testFolderExists = Directory.Exists(relativePath + "testFolder");
            Console.WriteLine("Case relative");
            Console.WriteLine(testFolderExists);
            bool testFolder2Exists = Directory.Exists(absoluthPath + "bin");
            Console.WriteLine("Case absolute");
            Console.WriteLine(testFolder2Exists);

            // creating new folder
            string newFolderName = "testFolderC#Adv";
            string newFolderPathAbsolute = 
                @$"C:\SEDC\SEDC08\c#Advanced\skwd8-06-csharpadv\g6\Class10\SEDC.Adv.Class10\SEDC.Adv.Class10.FileSystem\bin\Debug\netcoreapp3.1\{newFolderName}";
            // new folder path relative
            string newFolder = relativePath + "testFolderCreatedFromC#";
            //Console.WriteLine($"Does testFolderCreatedFromC# exists: {Directory.Exists(newFolder)}");
            //if (!Directory.Exists(newFolder))
            //{
            //    Directory.CreateDirectory(newFolder);
            //    Console.WriteLine("New folder was created");
            //}

            //Console.WriteLine($"Does testFolderCreatedFromC# exists: {Directory.Exists(newFolder)}");

            //Console.ReadLine();
            // deleting folder
            //if (Directory.Exists(newFolder))
            //{
            //    Directory.Delete(newFolder);
            //    Console.WriteLine("testFolderCreatedFromC# has been deleted");
            //}
            //Console.WriteLine("Does folder testFolderCreatedFromC# exists:");
            //Console.WriteLine(Directory.Exists(newFolder));
            #endregion

            string fileFolder = relativePath + @"testFolderCreatedFromC#\";

            // Creating directory
            if (!Directory.Exists(fileFolder))
            {
                Directory.CreateDirectory(fileFolder);
                Console.WriteLine("Folder is created");
            }

            bool testTxtExists = File.Exists(fileFolder + "test.txt");
            Console.WriteLine("Does test.txt exists:");
            Console.WriteLine(testTxtExists);

            // Creating file
            if(!File.Exists(fileFolder + "test.txt"))
            {
                File.Create(fileFolder + "test.txt").Close();
                Console.WriteLine("File was created");
            }

            Console.ReadLine();

            //// Deleting file
            //if(File.Exists(fileFolder + "test2.txt"))
            //{
            //    File.Delete(fileFolder + "test2.txt");
            //    Console.WriteLine("File was deleted");
            //}

            Console.ReadLine();
            // content to write in file
            string text = "Hello SEDC! We are writing in a file";
            // path for the file
            string filePath = fileFolder + "test.txt";

            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, text);
                Console.WriteLine("Successfuly written in a file!");
            }

            var filesToBeWritten = Directory.GetFiles(fileFolder);

            if (File.Exists(filePath))
            {
                File.AppendAllText(filePath, "\n" + text + " Second line");
                File.AppendAllLines(filePath, filesToBeWritten);
                Console.WriteLine("Successfuly written in a file!");
            }

            Console.ReadLine();

            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine("This is the content:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(content);
                Console.ResetColor();
            }

            var files = Directory.GetFiles(fileFolder);

            foreach (var file in files)
            {
                Console.WriteLine(file);
            }


            Console.ReadLine();
        }
    }
}
