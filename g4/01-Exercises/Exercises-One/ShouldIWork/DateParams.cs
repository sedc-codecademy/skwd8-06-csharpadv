using System;
using System.Collections.Generic;
using System.Linq;

namespace ShouldIWork
{
    public class DateParams
    {
        public int Date { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public DateTime AsDateTime()
        {
            return new DateTime(Year, Month, Date);
        }

        public bool IsWeekend()
        {
            var datetime = AsDateTime();
            if (datetime.DayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }
            if (datetime.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            return false;
        }

        public bool IsHoliday()
        {
            return Holidays.Any(h => h.Date == Date && h.Month == Month);
        }

        public override string ToString()
        {
            return $"{Date}/{Month}/{Year}";
        }

        public static List<DateParams> Holidays = new List<DateParams>
        {
            new DateParams { Date = 1, Month = 1},
            new DateParams { Date = 7, Month = 1},
            new DateParams { Date = 20, Month = 4},
            new DateParams { Date = 1, Month = 5},
            new DateParams { Date = 24, Month = 5},
            new DateParams { Date = 2, Month = 8},
            new DateParams { Date = 8, Month = 9},
            new DateParams { Date = 11, Month = 10},
            new DateParams { Date = 23, Month = 10},
            new DateParams { Date = 8, Month = 12},
        };


    }

}