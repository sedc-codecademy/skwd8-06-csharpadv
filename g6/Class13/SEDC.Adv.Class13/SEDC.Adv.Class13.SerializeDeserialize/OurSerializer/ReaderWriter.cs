using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.Adv.Class13.SerializeDeserialize.OurSerializer
{
    public class ReaderWriter
    {
        public string ReadFile(string path)
        {
            string result = string.Empty;
            if (!File.Exists(path))
            {
                return "File does not exists";
            }

            using (StreamReader sr = new StreamReader(path, true))
            {
                result = sr.ReadToEnd();
            }
            Console.WriteLine("Successfuly read a file");
            return result;
        }

        public void WriteFile(string path, string data)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(data);
            }
            Console.WriteLine("Successfuly written in file");
        }
    }
}
