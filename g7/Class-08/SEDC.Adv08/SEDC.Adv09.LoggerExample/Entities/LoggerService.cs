using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.Adv09.LoggerExample.Entities
{
	// This class will be a class that helps us log stuff somewhere on the FS
	// We can use it to log errors or some other stuff that are important for us
	public class LoggerService
	{
		// First we need to set the paths for the files and folders
		private string _directoryPath = @"..\..\..\logs";
		private string _errorLogPath = @"..\..\..\logs\errors.txt";
		private string _errorCountPath = @"..\..\..\logs\errorCount.txt";

		// Create a constructor that will make sure the folder logs exists
		public LoggerService()
		{
			// We check if the directory for logs exists and if it doesn't we create it
			if (!Directory.Exists(_directoryPath))
			{
				Directory.CreateDirectory(_directoryPath);
			}
		}

		// Log some information
		public void Log(string error, string message, string username = "Unknown")
		{
			// We add _errorLogPath to specify the path where we want to write
			// We add true to specify that we don't want to overwrite the text that was previously there
			StreamWriter sw = new StreamWriter(_errorLogPath, true);
			sw.WriteLine($"[Error] {error}");
			sw.WriteLine($"Time: {DateTime.Now.ToLocalTime()}");
			sw.WriteLine($"Message: {message}");
			sw.WriteLine($"User: {username}");
			sw.WriteLine($"----------------------------------");
			sw.Dispose();
		}

		// Update the count of errors in the errorCount file
		public void UpdateErrorCount()
		{
			int count = 0;
			// We check if the file exists and create it if it doesn't
			// We didn't do this in the log method beause StreamWriter automatically creates the file if it does not exist
			// StreamReader on the other hand does not automatically create a file
			if (!File.Exists(_errorCountPath))
			{
				File.Create(_errorCountPath).Close();
			}

			// Read the previous number from the file ( So that we can append + 1 to that number )
			// We need to do that so we know how many errors were logged before so that we can do + 1
			StreamReader sr = new StreamReader(_errorCountPath);
			// If this code does not parse the value ( if the file is empty ) it will not do anything and count will still stay at 0
			bool isNumber = int.TryParse(sr.ReadLine(), out count);
			// We close the connection to the file and dispose the class
			sr.Dispose();

			// We need to write the new value for the count
			// The old value is not relevant any more so that is why we will overwrite the file
			StreamWriter sw = new StreamWriter(_errorCountPath);
			// We update the counter by 1
			count++;
			// We write the count in the file
			sw.WriteLine(count);
			// We close the connection to the file and dispose the class
			sw.Dispose();
		}
	}
}
