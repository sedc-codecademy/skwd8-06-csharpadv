using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class02.Static
{
    public static class TextHelper
    {
        public static void ColorfulWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

    }
}
