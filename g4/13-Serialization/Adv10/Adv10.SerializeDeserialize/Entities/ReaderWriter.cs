using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Adv10.SerializeDeserialize.Entities
{
	public class ReaderWriter
	{
        public string ReadFile(string path)
        {
            string result = "";
            if (!File.Exists(path))
            {
                return "File does not exist!";
            }
            using (StreamReader sr = new StreamReader(path, true))
            {
                result = sr.ReadToEnd();
            }
            Console.WriteLine("Successfully read a file!");
            return result;
        }
        public void WriteFile(string path, string data)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(data);
            }
            Console.WriteLine("Successfully written a file!");
        }
    }
}
