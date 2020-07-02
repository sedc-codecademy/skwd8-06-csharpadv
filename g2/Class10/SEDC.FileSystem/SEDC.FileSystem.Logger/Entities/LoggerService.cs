using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.FileSystem.Logger.Entities
{
    public class LoggerService
    {
        private string _directoryPath = @"..\..\..\logs";
        private string _errorCountPath = @"..\..\..\logs\errorCount.txt";
        private string _logPath = @"..\..\..\logs\log.txt";


        public LoggerService()
        {
            if (!Directory.Exists(_directoryPath))
            {
                Directory.CreateDirectory(_directoryPath);
            }
        }

        public void Log(string error, string message, string username = "unknown")
        {
            using (StreamWriter sw = new StreamWriter(_logPath, true))
            {
                sw.WriteLine($"Error: {error}");
                sw.WriteLine($"Time: {DateTime.Now.ToLocalTime()}");
                sw.WriteLine($"Message: {message}");
                sw.WriteLine($"Username: {username}");
                sw.WriteLine("-------------------------------------------");
            }
        }

        public void LogError()
        {
            int count = 0;
            if (!File.Exists(_errorCountPath))
            {
                File.Create(_errorCountPath).Close();
            }

            using (StreamReader sr = new StreamReader(_errorCountPath))
            {
                bool isNum = int.TryParse(sr.ReadLine(), out count);
            }

            using (StreamWriter sw = new StreamWriter(_errorCountPath))
            {
                sw.WriteLine(count + 1);
            }
        }

    }
}
