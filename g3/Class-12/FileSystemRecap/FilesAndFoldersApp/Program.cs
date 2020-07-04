using System;
using System.IO;
using System.Threading;

namespace FilesAndFoldersApp
{
    class Program
    {
        private static string _thisPath { get; set; } = Directory.GetCurrentDirectory();

        static void Main(string[] args)
        {
            FileFolderService fileFolderService = new FileFolderService();

            if (fileFolderService.CreateFile(_thisPath, "firstFile.txt"))
            {
                Console.WriteLine("File created");
            }
            else
            {
                Console.WriteLine("File already exists");
            }

            fileFolderService.CreateFile(_thisPath, "secondFile.txt", "this is just a content for the second file!!!");

            fileFolderService.CreateFolder(_thisPath, "firstFolder");

            Console.ReadKey();
        }
    }
}
