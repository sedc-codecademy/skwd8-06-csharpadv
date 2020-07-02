using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Services
{
    public class Logger
    {
        private string _logPath { get; set; } // A private property that contains the whole absolute path to the log.txt file

        public Logger(string fileName)
        {
            //_logPath = $@"{Directory.GetCurrentDirectory()}/{fileName}"; // A manual way of combining multiple paths
            _logPath = Path.Combine(Directory.GetCurrentDirectory(), fileName); // This will combine multiple paths into one, A cleaner way
        }

        public void Log(string username, string message) // Logs an informational message to the log.txt file
        {
            if (File.Exists(_logPath))
            {
                using (var logWriter = new StreamWriter(_logPath, append: true))
                {
                    logWriter.WriteLine($"[{DateTime.Now}] By user: {username} Message: {message}");
                }
            }
        }

        public void LogError(string errorMessage, string stackTrace, Dictionary<string, object> parametars) // Logs an error message to the log.txt file
        {
            if (File.Exists(_logPath))
            {
                using (var logWriter = new StreamWriter(_logPath, append: true))
                {
                    string aggregatedParams = string.Empty;
                    foreach (KeyValuePair<string, object> param in parametars)
                    {
                        aggregatedParams += $"{param.Key}: {param.Value.ToString()}";
                    }

                    logWriter.Write($"[ERROR] [{DateTime.Now}] Message: {errorMessage} StackTrace: {stackTrace} Params: {aggregatedParams}");
                }
            }
        }

        public void LogError(Exception exception) // Another way to log an error message to the log.txt file
        {
            if (File.Exists(_logPath))
            {
                using (var logWriter = new StreamWriter(_logPath, append: true))
                {
                    logWriter.Write($"[ERROR] [{DateTime.Now}] Message: {exception.Message} StackTrace: {exception.StackTrace}");
                }
            }
        }
    }
}
