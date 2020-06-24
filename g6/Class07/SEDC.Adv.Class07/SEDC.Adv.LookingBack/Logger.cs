using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.LookingBack
{
    public class Logger : LoggerBase
    {
        private ConsoleColor _color = ConsoleColor.Red;
        private bool _clearScreen = false;

        public override void LogError(string message)
        {
            if (_clearScreen)
            {
                Console.Clear();
            }
            Console.ForegroundColor = _color;
            base.LogError(message);
            ResetDefault();
        }

        public void LogError(string message, ConsoleColor color)
        {
            _color = color;
            LogError(message);
        }

        public void LogError(string message, bool clearScreen)
        {
            _clearScreen = clearScreen;
            LogError(message);
        }

        public void LogError(string message, ConsoleColor color, bool clearScreen)
        {
            _color = color;
            _clearScreen = clearScreen;
            LogError(message);
        }

        public override void LogInfo(string message)
        {
            // logic here...
            Console.ForegroundColor = ConsoleColor.Blue;
            base.LogInfo(message);
            Console.ResetColor();
        }

        public override void LogWarning(string message)
        {
            base.LogWarning(message);
        }

        private void ResetDefault()
        {
            _color = ConsoleColor.Red;
            _clearScreen = false;
        }
    }
}
