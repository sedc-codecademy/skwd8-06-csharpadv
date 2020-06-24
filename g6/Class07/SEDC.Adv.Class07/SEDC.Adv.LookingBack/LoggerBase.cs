using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.LookingBack
{
    public abstract class LoggerBase : BaseLogger
    {
        public virtual void LogInfo(string message)
        {
            Console.WriteLine($"{_infoMessage} {message}");
        }

        public virtual void LogWarning(string message)
        {
            Console.WriteLine($"{_warningMessage} {message}");
        }

        public virtual void LogError(string message)
        {
            Console.WriteLine($"{_errorMessage} {message}");
        }
    }
}
