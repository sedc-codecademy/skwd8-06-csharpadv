using System;
using System.IO;
using System.Threading;

namespace SEDC.FileSystem.ReadAndWrite
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Directory manipulation - Directory class
            //string curretnDirectory = Directory.GetCurrentDirectory();
            //Console.WriteLine(curretnDirectory);

            //Absolute path
            //string absolutePath = @"E:\Martin\SEDC\Trainer\2019-20\skwd8-06-csharpadv\g2\Class10\SEDC.FileSystem\SEDC.FileSystem.ReadAndWrite\bin\Debug\netcoreapp2.1";
            //Console.WriteLine(absolutePath);

            //Absoulte path to the console application root folder
            //string absoluteAppPath = @"E:\Martin\SEDC\Trainer\2019-20\skwd8-06-csharpadv\g2\Class10\SEDC.FileSystem\SEDC.FileSystem.ReadAndWrite";

            //Relative path - Relative to our application folder
            //string relativePath = @"..\..\..\";
            //Console.WriteLine(relativePath);


            //Check if folder exists
            //bool myFolderExists = Directory.Exists(relativePath + @"myFolder");
            //bool myFolderExistsString = Directory.Exists(@"E:\Martin\SEDC\Trainer\2019-20\skwd8-06-csharpadv\g2\Class10\SEDC.FileSystem\SEDC.FileSystem.ReadAndWrite\myFolder");
            //Console.WriteLine(myFolderExists);
            //Console.WriteLine(myFolderExistsString);


            //Create new folder
            //string newFolder = relativePath + @"\myNewFolder";
            //Console.WriteLine($"Does myNewFolder exists before: {Directory.Exists(newFolder)}");
            //if (!Directory.Exists(newFolder))
            //{
            //    Directory.CreateDirectory(newFolder);
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("New directory created successfully!");
            //    Console.ResetColor();
            //}
            //Console.WriteLine($"Does myNewFolder exists after: {Directory.Exists(newFolder)}");

            //Thread.Sleep(3000);

            //Delete a directory
            //if (Directory.Exists(newFolder))
            //{
            //    Directory.Delete(newFolder);
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("myNewFolder successfully deleted!");
            //    Console.ResetColor();
            //}


            #endregion


            #region File manipulation - File class
            string relativeAppPath = @"..\..\..\";
            string filePath = relativeAppPath + @"newFolderWithFile";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("New directory was created!");
                Console.ResetColor();
            }

            Thread.Sleep(4000);

            //File Create
            // newFolderWithFiletest.txt
            //if(!File.Exists(filePath + @"\test.txt"))
            //{
            //    File.Create(filePath + @"\test.txt").Close();
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("A file was created!");
            //}

            //Console.WriteLine("If you want to delete the test.txt file please press any key!");
            //Console.ReadLine();

            //File Delete
            //if(File.Exists(filePath + @"\test.txt"))
            //{
            //    File.Delete(filePath + @"\test.txt");
            //    Console.WriteLine("The file was deleted!");
            //}
            //else
            //{
            //    Console.WriteLine("The file is already deleted!");
            //}

            //string file = filePath + @"\test.txt";
            //if (File.Exists(file))
            //{
            //    File.WriteAllText(file, "Hello there! I just write in a file for the first time!");
            //    Console.WriteLine("Successfully written in a file!");
            //}

            //if (File.Exists(file))
            //{
            //    File.WriteAllText(file, "Hello there again! I just write in a file for the first time!");
            //    Console.WriteLine("Successfully written in a file!");
            //}


            //Console.WriteLine("Do you want to read from the file? Enter 'y' or 'n' ?");
            //string userInput = Console.ReadLine();

            //Read from a file
            //if(userInput == "y")
            //{
            //    if (File.Exists(file))
            //    {
            //        string content = File.ReadAllText(file);
            //        Console.WriteLine("The text from the test.txt file is");
            //        Console.WriteLine(content);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Okay! Have a nice day!");
            //}



            //Example of create/write/read in a file and folder

            Console.WriteLine("Hi user! Choose what do you want to do!");
            Console.WriteLine("1) Create a directory \n2) Create a new .txt file");

            int input = Convert.ToInt32(Console.ReadLine());
            string relativeApplicationPath = @"..\..\..\";
            if (input == 1)
            {
                Console.WriteLine("Please enter the name for your folder!");
                string folderName = Console.ReadLine();

                string fullPath = String.Format(@"{0}\{1}", relativeApplicationPath, folderName);

                if (!Directory.Exists(fullPath))
                {
                    Directory.CreateDirectory(fullPath);
                    Console.WriteLine("New directory created successfully");
                }
            }
            else if(input == 2)
            {
                Console.WriteLine("Please enter the name for your file!");
                string fileName = Console.ReadLine();

                string fullFilePath = String.Format(@"{0}\{1}", relativeApplicationPath, fileName);

                if (!File.Exists(fullFilePath))
                {
                    File.Create(fullFilePath).Close();
                    Console.WriteLine("New file created successfully");
                }

                Console.WriteLine("Do you want to input some text in your file? Enter Y/N");
                string enterTextInput = Console.ReadLine();

                if(enterTextInput == "Y")
                {
                    Console.WriteLine("Enter your text!");
                    string text = Console.ReadLine();

                    if (File.Exists(fullFilePath))
                    {
                        File.WriteAllText(fullFilePath, text);
                        Console.WriteLine("The text was successfully entered! Please check your file!");
                    }
                    else
                    {
                        Console.WriteLine("Something went wrong! The file probably doesn't exists!");
                    }
                }
                else
                {
                    Console.WriteLine("Thank you! Have a nice day!");
                }
            }



            #endregion


            Console.ReadLine();
        }
    }
}
