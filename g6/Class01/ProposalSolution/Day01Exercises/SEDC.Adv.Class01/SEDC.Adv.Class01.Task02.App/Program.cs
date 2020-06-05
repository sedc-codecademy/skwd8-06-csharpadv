using SEDC.Adv.Class01.Task02.Logic.Dates;
using System;
using System.Collections.Generic;

namespace SEDC.Adv.Class01.Task02.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var freeDayService = new FreeDayService();

            for (int i = 1990; i < 2020; i++)
            {
                var month = (i % 12) + 1;
                var day = (int)(DateTime.Now.Ticks % (DateTime.DaysInMonth(i, month))) + 1; 
                var date = new DateTime(i, month, day);

                var result = freeDayService.CheckIfDateIsNonWorkingDay(date);
                var working = result ? "non working" : "working";
                Console.WriteLine($"Date: {date.ToShortDateString()} is {working} day");
            }

            Console.WriteLine("---------------------- SECOND WAY --------------------------");

            for (int i = 1990; i < 2020; i++)
            {
                var month = (i % 12) + 1;
                var day = (DateTime.UtcNow.Millisecond % (DateTime.DaysInMonth(i, month))) + 1;
                var date = new DateTime(i, month, day);

                var result = freeDayService.CheckIfDateIsNonWorkingDay1(date);
                var working = result ? "non working" : "working";
                Console.WriteLine($"Date: {date.ToShortDateString()} is {working} day");
            }

            Console.WriteLine("---------------------- THIRD WAY --------------------------");

            for (int i = 1990; i < 2020; i++)
            {
                var month = (i % 12) + 1;
                var day = (DateTime.Now.Millisecond % (DateTime.DaysInMonth(i, month))) + 1;
                var date = new DateTime(i, month, day);

                var result = freeDayService.CheckIfDateIsNonWorkingDay2(date);
                var working = result ? "non working" : "working";
                Console.WriteLine($"Date: {date.ToShortDateString()} is {working} day");
            }

            Console.ReadLine();
        }
    }
}
