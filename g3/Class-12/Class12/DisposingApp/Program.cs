using System;
using System.IO;

namespace DisposingApp
{
    class Program
    {
        private static string _thisPath { get; set; } = Directory.GetCurrentDirectory();

        static void Main(string[] args)
        {
            FileFolderService fileFolderService = new FileFolderService();

            fileFolderService.CreateFileManual(_thisPath, "first.txt", "just some content for first file");
            fileFolderService.CreateFileAutomatic(_thisPath, "second.txt", "just some content for second file");
            fileFolderService.CreateFileCustomManual(_thisPath, "third.txt", "just some content for third file");
            fileFolderService.CreateFileCustomAutomatic(_thisPath, "fourth.txt", "just some content for fourth file");
            fileFolderService.CreateFileCustomAutomatic2(_thisPath, "fifth.txt", "just some content for fifth file");

            Console.ReadKey();
        }
    }
}
