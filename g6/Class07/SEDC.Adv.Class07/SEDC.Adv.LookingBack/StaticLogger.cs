using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.LookingBack
{
    public static class StaticLogger
    {
        public static int ID { get; set; }

        static StaticLogger()
        {
            ID = 0; 
        }

        public static void PrintId()
        {
            Console.WriteLine(ID);
            ID++;
        }

        public static string Add3(string str)
        {
            return str + 3;
        }
    }
}
