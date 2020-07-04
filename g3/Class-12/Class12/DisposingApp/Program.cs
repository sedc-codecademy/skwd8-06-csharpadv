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

            int num1 = 3;
            int num2 = num1;
            num2 = 4;

            var ser1 = new FileFolderService();
            var ser2 = ser1;
            ser2 = new CustomWriter();

            Console.ReadKey();
        }
    }
}
