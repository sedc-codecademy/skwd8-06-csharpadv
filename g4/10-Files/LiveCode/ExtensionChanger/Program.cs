using System;
using System.IO;

namespace ExtensionChanger
{
    class Program
    {
        static void Main(string[] args)
        {
            var folderName = @"C:\Source\SEDC\skwd8-06-csharpadv\g4\10-Files\input";
            var files = Directory.GetFiles(folderName);
            foreach (var file in files)
            {
                var extension = Path.GetExtension(file);
                if (extension == ".txt")
                {
                    var newFileName = Path.ChangeExtension(file, ".out");
                    File.Move(file, newFileName);
                }
            }
        }
    }
}
