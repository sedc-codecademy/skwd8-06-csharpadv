using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodsDemo
{
    static class PolynomGenerator
    {
        public static int Power(this int input, int power)
        {
            return (int)Math.Pow(input, power);
        }

        public static int Multiply(this int input, int factor)
        {
            return input * factor;
        }

        public static int Add(this int input, int factor)
        {
            return input + factor;
        }


    }
}
