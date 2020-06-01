using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ShouldIWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while (loop)
            {
                var date = GetDateParams();
                bool isWorking = IsWorking(date);
                if (isWorking)
                {
                    Console.WriteLine($"{date} is a working day, comrade");
                }
                else
                {
                    Console.WriteLine($"{date} is NOT a working day, you can sleep in");
                }

                Console.WriteLine("Check another date? [Y/n]");
                var loopInput = Console.ReadLine();
                loop = loopInput != "n";
            }
        }

        private static bool IsWorking(DateParams date)
        {
            if (date.IsWeekend())
            {
                return false;
            }
            if (date.IsHoliday())
            {
                return false;
            }
            return true;
        }

        private static DateParams GetDateParams()
        {
            Console.WriteLine("Enter the date you want to check");
            if (!int.TryParse(Console.ReadLine(), out int date))
            {
                Console.WriteLine("You entered an invalid date, setting date to today's date");
                date = DateTime.Today.Day;
            };

            Console.WriteLine("Enter the month you want to check");
            if (!int.TryParse(Console.ReadLine(), out int month))
            {
                Console.WriteLine("You entered an invalid month, setting month to today's month");
                month = DateTime.Today.Month;
            };

            Console.WriteLine("Enter the year you want to check");
            if (!int.TryParse(Console.ReadLine(), out int year))
            {
                Console.WriteLine("You entered an invalid year, setting date to current year");
                year = DateTime.Today.Year;
            };

            return new DateParams
            {
                Date = date,
                Month = month,
                Year = year
            };
        }
    }
}
