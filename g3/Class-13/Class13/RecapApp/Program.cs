using Microsoft.VisualBasic;
using Services;
using System;

namespace RecapApp
{
    class Program
    {

        private static FileFolderService _fileFolderService { get; set; } = new FileFolderService();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter something to write to a file:");
            string userInput = Console.ReadLine();

            _fileFolderService.Write("myFirstFile", userInput);
            Console.WriteLine(_fileFolderService.Read("myFirstFile"));



            // Struct vs Class
            var vazna1 = new Product { Id = 1, Name = "Vazna" };
            var vazna2 = new Product { Id = 1, Name = "Vazna" };
            var vazna3 = vazna1;

            Console.WriteLine(vazna1.Equals(vazna2));
            Console.WriteLine(vazna1.Equals(vazna3));


            // This will store 3 different copies of DateTime.Now because it is a struct, if it was class all 3 variables would point to 1 DateTime.Now
            var date1 = DateTime.Now;
            var date2 = DateTime.Now;
            var date3 = DateTime.Now;

            Console.WriteLine(date1.Ticks);
            Console.WriteLine(date2.Ticks);
            Console.WriteLine(date3.Ticks);


            Console.ReadKey();
        }
    }
}
