using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Statics
{
    public static class Calculator
    {
        public static double Pi { get; } = 3.14;

        public static (int Result, int Remainder) Divide(int first, int second)
        {
            var result = first / second;
            var remainder = first % second;
            return (result, remainder);
        }
        public static int Exponent(int first, int second)
        {
            var result = 1;
            for (int i = 0; i < second; i++)
            {
                result *= first;
            }
            return result;
        }

        public static int Multiply(int first, int second)
        {
            return first * second;
        }

        public static int Multiply(int first, int second, int third)
        {
            return first * second * third;
        }

        public static double Multiply(double first, double second)
        {
            return first * second;
        }


        internal static double CircleLenght(int first)
        {
            return 2 * first * Pi;
        }

    }



}
