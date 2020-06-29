using System;
using System.IO;

namespace SEDC.Adv08.ReaderWriter
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Setup
			// File path
			string fileName = @"file.txt";
			// Project Directory
			string folderPath = @"..\..\..\myFolder\";
			string filePath = folderPath + fileName;

			if (!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
			}
			#endregion

			#region StreamWriter
			// Stream writer will create the file if it doesn't exist
			// It will not create a folder if it doesn't exist
			// IF the file exist then it writes in the file

			// First we create an instace of the StreamWriter
			StreamWriter sw = new StreamWriter(filePath);
			// Then we use that instance. That instance has a connection to the file
			sw.WriteLine("Hello SEDC!");
			sw.WriteLine("We are writing this from the console app from the StreamWriter!");
			sw.WriteLine("Ant this is the last line!");
			// After we are done, we call the Dispose() method on the object so we disconnect from the file
			// If we don't use Dispose() the file will be used and we can't do anything with it 
			// Close -> Closes the connection to a file ( Because File is a static class and does not need disposing )
			// Dispose -> Clears the object from memory as well as close all connections ( Because StreamWriter is an instance )
			sw.Dispose();
			Console.WriteLine("We wrote some stuff in a file!");
			Console.WriteLine("------------------------------");

			// First we create an instace of the StreamWriter without rewriting the previous text
			StreamWriter sw1 = new StreamWriter(filePath, true); // The second parameter true indicates that the text will be appended instead of replaced
			// Then we use that instance. That instance has a connection to the file
			sw1.WriteLine("Hello again SEDC!");
			sw1.Dispose();
			Console.WriteLine("We wrote some stuff in a file!");
			Console.WriteLine("------------------------------");
			#endregion
			#region StreamReader

			// First we create an instance of the StreamReader
			StreamReader sr = new StreamReader(filePath);

			Console.WriteLine("The first line says: ");
			Console.WriteLine(sr.ReadLine()); // Reads the first line ( if we call it again, the second, and so on )
			Console.WriteLine("The rest of the file says: ");
			Console.WriteLine(sr.ReadToEnd()); // Read the whole text
			Console.WriteLine("------------------------------");

			// When our app closes, everything is disposed anyways
			// But if we don't dispose and we want to keep using the file, we will run in to an error saying the file is in use
			sr.Dispose();
			#endregion

			Console.ReadLine();
		}
	}
}
