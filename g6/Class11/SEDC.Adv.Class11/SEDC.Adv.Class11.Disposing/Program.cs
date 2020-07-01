using System;
using System.IO;

namespace SEDC.Adv.Class11.Disposing
{
    class Program
    {
        public static string AppPath = @"..\..\..\test";
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

        #region Manual Dispose
        public static void AppendTextInFile(string text, string path)
        {
            StreamWriter sw = new StreamWriter(path, true);
            if(text == "break")
            {
                throw new Exception("Something went wrong...");
            }
            sw.WriteLine(text);
            sw.Dispose();
        }

        public static void ReadTextFromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            Console.WriteLine(sr.ReadToEnd());
            sr.Dispose();
        }

        public static void ManualExample()
        {
            try
            {
                Console.WriteLine("Enter text1: ");
                string text1 = Console.ReadLine();
                AppendTextInFile(text1, FilePath);

                Console.WriteLine("Enter text2: ");
                string text2 = Console.ReadLine();
                AppendTextInFile(text2, FilePath);

                Console.WriteLine("Enter text3: ");
                string text3 = Console.ReadLine();
                AppendTextInFile(text3, FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem in the writing system");
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("--READ--");
                Console.ReadLine();
                ReadTextFromFile(FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem in the reading system");
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Dispose with using block
        public static void AppendTextInFileSafe(string text, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                if(text == "break")
                {
                    throw new Exception("Something went bad while writing");
                }
                sw.WriteLine(text);
            }
        }

        public static void ReadTextFromFileSafe(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }

        public static void UsingExample()
        {
            try
            {
                Console.WriteLine("Enter text1: ");
                string text1 = Console.ReadLine();
                AppendTextInFileSafe(text1, FilePath);

                Console.WriteLine("Enter text2: ");
                string text2 = Console.ReadLine();
                AppendTextInFileSafe(text2, FilePath);

                Console.WriteLine("Enter text3: ");
                string text3 = Console.ReadLine();
                AppendTextInFileSafe(text3, FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem in the writing system");
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("--READ--");
                Console.ReadLine();
                ReadTextFromFileSafe(FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem in the reading system");
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        #region Dispose with our own class
        public static void AppendTextInFileOurImplementation(string text, string path)
        {
            using (OurWriter ow = new OurWriter(path))
            {
                if(text == "break")
                {
                    throw new Exception("Something went wrong...");
                }
                ow.Write(text);
            }
        }

        public static void ReadTextInFileOurImplementation(string path)
        {
            using(OurReader or = new OurReader(path))
            {
                Console.WriteLine(or.Read());
            }
        }

        public static void OurDisposableExample()
        {
            try
            {
                Console.WriteLine("Enter text1: ");
                string text1 = Console.ReadLine();
                AppendTextInFileOurImplementation(text1, FilePath);

                Console.WriteLine("Enter text2: ");
                string text2 = Console.ReadLine();
                AppendTextInFileOurImplementation(text2, FilePath);

                Console.WriteLine("Enter text3: ");
                string text3 = Console.ReadLine();
                AppendTextInFileOurImplementation(text3, FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem in the writing system");
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("--READ--");
                Console.ReadLine();
                ReadTextInFileOurImplementation(FilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine("There was a problem in the reading system");
                Console.WriteLine(ex.Message);
            }
        }
        #endregion

        static void Main(string[] args)
        {
            CreateFolder(AppPath);
            CreateFile(FilePath);

            //ManualExample();
            //UsingExample();
            OurDisposableExample();


            Console.ReadLine();
        }
    }
}
