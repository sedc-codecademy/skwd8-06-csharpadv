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

            #region Directory
            // Create dicrectory with absolute path, this might not work on you machine, you may need to change the paths to match you own PC
            if (Directory.Exists(@"C:\Users\d3jan\Desktop\toseidekiBabusi"))
            {
                Console.WriteLine("The directory already exists!");
            }
            else
            {
                Directory.CreateDirectory(@"C:\Users\d3jan\Desktop\toseidekiBabusi");
                Console.WriteLine("The directory was created!");
            }

            // Create dicrectory with relative path, this will work on any machine
            string newFolderPath = @".\toseidekiBabusi";
            if (Directory.Exists(newFolderPath))
            {
                Console.WriteLine("The directory already exists!");
                Console.WriteLine("Do you want to overwrite Y or N");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "y")
                {
                    Directory.Delete(newFolderPath);
                    Directory.CreateDirectory(newFolderPath);
                }
            }
            else
            {
                Directory.CreateDirectory(newFolderPath);
                Console.WriteLine("The directory was created!");
            }
            #endregion

            #region File
            //string newFilePath = Directory.GetCurrentDirectory() + @"\test.txt"; // A manual way of combining paths
            string newFilePath = Path.Combine(Directory.GetCurrentDirectory(), "test.txt"); // Using Path.Combine is more intuitive
            if (!File.Exists(newFilePath))
            {
                //File.Create(newFilePath).Close(); // Creates an empty file, but keeps the connection open, this means that the error => file is used by another proccess will appear, we need to close the connection manually
                File.WriteAllLines(newFilePath, new string[] { "line1", "line2", "line3" }); // Creates a file with a content, but closes the connection to the file, the error will not appear
                Console.WriteLine("File is created");
            }
            #endregion

            #region StreamWriter and StreamReader
            if (File.Exists(newFilePath))
            {
                // Using statement: it will use the "writer" variable only inside the scope, and after it's "used"(done) it will remove the variable from RAM memory, so it no longer takes unneccesery space
                using (var writer = new StreamWriter(newFilePath, append: true)) // StreamWriter helps us with a simpler methods to Write content on to the file, append: true means it will append the text, not overwrite
                {
                    writer.WriteLine("Tose");
                    writer.WriteLine("Dejan");
                    writer.WriteLine("Dragan");
                    writer.Write(" Tashev");
                }

                using (var reader = new StreamReader(newFilePath)) // StreamReader helps us with simpler methods to read content from a file
                {
                    string allContent = reader.ReadToEnd();
                    Console.WriteLine(allContent);
                }
            }

            #endregion


            Console.ReadKey();
        }
    }
}
