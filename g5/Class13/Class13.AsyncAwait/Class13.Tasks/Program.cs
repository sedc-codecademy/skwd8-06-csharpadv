using System;
using System.Threading.Tasks;

namespace Class13.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 200000;
            char charToConcatenate = '1';

            Task<string> t = Task.Factory.StartNew(() => ConcatenateChars(charToConcatenate, count));
            
            //Task t = new Task(() => ConcatcharToConcatenateenateChars(charToConcatenate, count));
            //t.Start();

            //ConcatenateChars();
            Console.WriteLine("In progress");

            t.Wait();
            Console.WriteLine("Completed");
            Console.WriteLine($"The length of the result is {t.Result.Length}");

            Console.ReadLine();
        }

        public static string ConcatenateChars(char characterToConcatenate, int count)
        {
            string concatenatedString = string.Empty;
            for (int i = 0; i < count; i++)
            {
                concatenatedString += characterToConcatenate;
            }

            return concatenatedString;
        }
    }
}
