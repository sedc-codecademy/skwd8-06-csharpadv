using System;
using System.IO;

namespace Disposing
{
    
    class Program
    {
        public static string AppPath = @"..\..\..\Text";
        public static string FilePath = AppPath + @"\text.txt";

        public static void CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public static void CreateFile(string path)
        { 
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
        public static void WriteTextInFile(string text, string path)
        {
            using (var sw = new StreamWriter(path, true))
            {
                sw.WriteLine(text);
            }
        }

        public static void WriteTextInFileManual (string text, string path)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(text);
            sw.Dispose();
        }

        public static void ReadTextFromFileManual(string path)
        {
            StreamReader sr = new StreamReader(path);
            Console.WriteLine(sr.ReadToEnd());
            sr.Dispose();
        }

        public static void ReadTextFromFile(string path)
        {
            using (var sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }

        public static void WriteAndReadInFileExample()
        {
            try
            {
                Console.WriteLine("Please enter text for pt1:");
                string text1 = Console.ReadLine();
                //WriteTextInFile(text1, FilePath);
                //WriteTextInFileManual(text1, FilePath);
                WriteTextInFileOurImplementation(text1, FilePath);

                Console.WriteLine("Please enter text for pt2:");
                string text2 = Console.ReadLine();
                //WriteTextInFile(text2, FilePath);
                // WriteTextInFileManual(text2, FilePath);
                WriteTextInFileOurImplementation(text2, FilePath);

                Console.WriteLine("Please enter text for pt3:");
                string text3 = Console.ReadLine();
                //WriteTextInFile(text3, FilePath);
                //WriteTextInFileManual(text3, FilePath);
                WriteTextInFileOurImplementation(text3, FilePath);
            }
            catch (Exception ex)
            {

                Console.WriteLine("There was a problem in the writing file");
                Console.WriteLine(ex.Message);
            }
            

            Console.Clear();
            Console.WriteLine("------------- You entered ------------------");
            try
            {
                // ReadTextFromFile(FilePath)
                ReadTextFromFileManual(FilePath);
            }
            catch (Exception ex)
            {

                Console.WriteLine("There was a problem in the reading file");
                Console.WriteLine(ex.Message);
            }
            
        }

        public static void WriteTextInFileOurImplementation(string text, string path)
        {
            //using(var ow = new CustomReaderWriter(path))
            //{
            //    ow.WriteInFile(text);
            //}
            var ow = new CustomReaderWriter(FilePath);
            ow.Dispose();
        }

        static void Main(string[] args)
        {
            CreateFolder(AppPath);
            CreateFile(FilePath);

            WriteAndReadInFileExample();
        }
    }
}
