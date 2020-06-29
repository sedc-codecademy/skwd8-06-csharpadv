using System;
using System.IO;

namespace SEDC.Adv08.FileSystem
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Paths
			// Absolute path
			// File path
			string consoleAbsolutePath = @"C:\Dragan\Personal\SEDC\advanced\students\skwd8-06-csharpadv\g7\Class-08\SEDC.Adv08\SEDC.Adv08.FileSystem\bin\Debug\netcoreapp2.1\file.txt";
			// Project Directory
			string consoleAbsoluteDirectory = @"C:\Dragan\Personal\SEDC\advanced\students\skwd8-06-csharpadv\g7\Class-08\SEDC.Adv08\";
			// Relative path
			// File path
			string fileName = @"file.txt";
			// Project Directory
			// ..\ => Go back one folder ( To the parent )
			string appPath = @"..\..\..\";
			#endregion

			#region Directory


			// Get the current directory of the application where it is executed
			string currentDirectory = Directory.GetCurrentDirectory();
			Console.WriteLine("Current Directory: ");
			Console.WriteLine(currentDirectory);
			Console.WriteLine("------------------------");

			// Checks if a folder exists on a particular path and returns true or false
			// The path that we chose is our project main folder and we are looking for a folder named myFolder
			bool myFolderExists = Directory.Exists(appPath + "myFolder");
			Console.WriteLine($"Is there myFolder in our app path: {myFolderExists}");
			Console.WriteLine("-------------------------");

			// Create a new folder
			string newFolderPath = appPath + "newFolder";
			// First we check if the folder exists so we don't try and create it, but it is already there
			if (!Directory.Exists(newFolderPath))
			{
				// If the directory does not exist, then we create it
				Directory.CreateDirectory(newFolderPath);
				Console.WriteLine("New directory was created!");
				Console.WriteLine("------------------------");
			}

			// Delete a folder
			Console.WriteLine("Press enter to delete the folder newFolder...");
			Console.ReadLine();
			
			// IF the folder exists, then we can delete because we can't delete something that does not exist 
			if (Directory.Exists(newFolderPath))
			{
				// If the directory does not exist, then we delete it
				// This deletes the folder permanently ( Shift + Delete )
				Directory.Delete(newFolderPath);
				Console.WriteLine("Directory was deleted!");
				Console.WriteLine("------------------------");
			}
			#endregion
			#region File
			string filePath = $@"{appPath}myFolder\{fileName}";

			// Does file exist
			bool doesFileExist = File.Exists(filePath);
			Console.WriteLine($"Does the file file.txt exist: {doesFileExist}");
			Console.WriteLine("------------------------");

			// Create a file
			// We check if the file does not exist, so we don't create a file that already exists
			if (!File.Exists(filePath))
			{
				// The file opens a connection to the FS ( File System )
				// We must close the connecton after we are done creating this file
				// If we don't the next time we try to use it, it will throw an error saying it is in use
				File.Create(filePath).Close();
				Console.WriteLine("A file was created!");
				Console.WriteLine("------------------------");
			}

			// Delete a file
			// We check if the file exists, so we don't delete a file that does not exist
			if (File.Exists(filePath))
			{
				Console.WriteLine("Type delete to delete the file:");
				if(Console.ReadLine() == "delete")
				{
					File.Delete(filePath);
					Console.WriteLine("A file was deleted!");
				}
				Console.WriteLine("------------------------");
			}

			// Write in a file ( Rewrites the whole text )
			if (File.Exists(filePath))
			{
				// To write in a file we give the path to the file and then the text
				File.WriteAllText(filePath, "Hello SEDC! We wrote this text from the console app!");
				Console.WriteLine("Write sucessfull");
				Console.WriteLine("------------------------");
			}

			// Write in a file ( Append text )
			if (File.Exists(filePath))
			{
				// To write in a file we give the path to the file and then the text
				File.AppendAllText(filePath, " We added this later!");
				Console.WriteLine("Append sucessfull");
				Console.WriteLine("------------------------");
			}

			// Read a file
			if (File.Exists(filePath))
			{
				// To read from a file we need to just give the path and save the result in a string
				string textFromFile = File.ReadAllText(filePath);
				Console.WriteLine("Text in file is: ");
				Console.WriteLine(textFromFile);
				Console.WriteLine("------------------------");
			}
			#endregion
			Console.ReadLine();
		}
	}
}
