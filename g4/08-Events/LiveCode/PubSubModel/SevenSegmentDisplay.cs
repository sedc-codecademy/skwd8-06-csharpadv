using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubModel
{
    public class SevenSegmentDisplay
    {
        public void DisplayTemp (int temp)
        {
            Console.WriteLine("SS Display");
            var digits = temp.ToString().Split("");
            foreach (var digit in digits)
            {
                Console.WriteLine(digit);
            }
        }
    }
}
