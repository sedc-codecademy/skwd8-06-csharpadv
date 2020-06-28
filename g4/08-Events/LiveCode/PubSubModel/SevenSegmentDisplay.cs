using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PubSubModel
{
    public class SevenSegmentDisplay
    {
        public void DisplayTemp (int temp)
        {
            var digits = temp.ToString().ToCharArray();
            // digits.Select(d => ToSSDisplay(d));

            foreach (var digit in digits)
            {
                foreach (var line in ToSSDisplay(digit))
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine();
            }
        }

        public static string[] ToSSDisplay(char digit)
        {
            return digit switch {
                '0' => new string[] { "#####", "#   #", "#   #", "#   #", "#####" },
                '1' => new string[] { "    #", "    #", "    #", "    #", "    #" },
                '2' => new string[] { "#####", "    #", "#####", "#    ", "#####" },
                '3' => new string[] { "#####", "    #", "#####", "    #", "#####" },
                '4' => new string[] { "#   #", "#   #", "#####", "    #", "    #" },
                '5' => new string[] { "#####", "#    ", "#####", "    #", "#####" },
                '6' => new string[] { "#####", "#    ", "#####", "#   #", "#####" },
                '7' => new string[] { "#####", "    #", "    #", "    #", "    #" },
                '8' => new string[] { "#####", "#   #", "#####", "#   #", "#####" },
                '9' => new string[] { "#####", "#   #", "#####", "    #", "#####" },
                _ => new string[] { "     ", "     ", "     ", "     ", "     " },
            };
        }
    }
}
