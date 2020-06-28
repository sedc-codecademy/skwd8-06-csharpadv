using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing
{
    public static class Random
    {
        private static System.Random random = new System.Random();

        public static int RandomUpTo(this int maxValue)
        {
            return random.Next(maxValue);
        }
    }
}
