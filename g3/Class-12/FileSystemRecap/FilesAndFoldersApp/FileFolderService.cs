using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FilesAndFoldersApp
{
    public class FileFolderService
    {
        public bool CreateFile(string path, string fileName)
        {
            string pathCombined = Path.Combine(path, fileName);

            if (!File.Exists(pathCombined))
            {
                File.Create(pathCombined).Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CreateFile(string path, string fileName, string content)
        {
            string pathCombined = Path.Combine(path, fileName);

            if (!File.Exists(pathCombined))
            {
                FileStream currentFile = File.Create(pathCombined);

                using (var writer = new StreamWriter(currentFile))
                {
                    writer.WriteLine(content);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CreateFolder(string path, string folderName)
        {
            string pathCombined = Path.Combine(path, folderName);

            if (!Directory.Exists(pathCombined))
            {
                Directory.CreateDirectory(pathCombined);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
