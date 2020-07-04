using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DisposingApp
{
    public class FileFolderService
    {
        public bool CreateFileManual(string path, string fileName, string content)
        {
            string _fullPath = Path.Combine(path, fileName);

            if (!File.Exists(_fullPath))
            {

                FileStream file = File.Create(_fullPath);
                StreamWriter writer = new StreamWriter(file);

                
                writer.WriteLine(content);

                //file.Close();
                writer.Dispose();

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CreateFileAutomatic(string path, string fileName, string content)
        {
            string _fullPath = Path.Combine(path, fileName);

            if (!File.Exists(_fullPath))
            {
                FileStream file = File.Create(_fullPath);

                using (StreamWriter writer = new StreamWriter(file))
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

        public bool CreateFileCustomManual(string path, string fileName, string content)
        {
            string _fullPath = Path.Combine(path, fileName);

            if (!File.Exists(_fullPath))
            {
                FileStream file = File.Create(_fullPath);
                CustomWriter writer = new CustomWriter(file);

                writer.Write(content);

                writer.Dispose();

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CreateFileCustomAutomatic(string path, string fileName, string content)
        {
            string _fullPath = Path.Combine(path, fileName);

            if (!File.Exists(_fullPath))
            {
                FileStream file = File.Create(_fullPath);
                using (CustomWriter writer = new CustomWriter(file))
                {
                    writer.Write(content);
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CreateFileCustomAutomatic2(string path, string fileName, string content)
        {
            string _fullPath = Path.Combine(path, fileName);

            if (!File.Exists(_fullPath))
            {
                FileStream file = File.Create(_fullPath);
                using CustomWriter writer = new CustomWriter(file);

                writer.Write(content);

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
