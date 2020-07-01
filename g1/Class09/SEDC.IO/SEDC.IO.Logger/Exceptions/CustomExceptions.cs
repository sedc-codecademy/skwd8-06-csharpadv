using SEDC.IO.Logger.Services;
using System;

namespace SEDC.IO.Logger.Exceptions
{
    public class InvalidUserException : Exception
    {
        private LoggerService _loggerService = new LoggerService();

        public InvalidUserException()
            : base("Unknown or invalid user.")
        {
            _loggerService.Log("Invalid user", "Unknown user tried to log in");
        }

        public InvalidUserException(string message)
            : base(message)
        {
            _loggerService.Log("Invlaid user", message);
        }
    }
}
