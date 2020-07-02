using System;
using System.IO;

namespace FileAndDirectoryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Absolute vs Relative
            //// Absolute Path
            //string absolutePathExample = @"C:/Users/d3jan/Desktop/repos/skwd8 - 06 - csharpadv/g3";

            //// Relative Path
            //string relativePathExample = @"./index.js";
            #endregion

            //// Create dicrectory with absolute path
            //if (Directory.Exists(@"C:\Users\d3jan\Desktop\toseidekiBabusi"))
            //{
            //    Console.WriteLine("The directory already exists!");
            //}
            //else
            //{
            //    Directory.CreateDirectory(@"C:\Users\d3jan\Desktop\toseidekiBabusi");
            //    Console.WriteLine("The directory was created!");
            //}

            // Create dicrectory with relative path
            string newFolderPath = @".\toseidekiBabusi";
            if (Directory.Exists(newFolderPath))
            {
                Console.WriteLine("The directory already exists!");
                Console.WriteLine("Do you want to overwrite Y or N");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "y")
                {
                    Directory.Delete(newFolderPath);
                    //Directory.CreateDirectory(newFolderPath);
                }
            }
            else
            {
                Directory.CreateDirectory(newFolderPath);
                Console.WriteLine("The directory was created!");
            }

            


            Console.ReadKey();
        }
    }
}
