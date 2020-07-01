using System;
using System.IO;

namespace SEDC.Adv09.Disposing
{
	// USE CASE
	// We need to write stuff in a file and read stuff from the same file as well
	// We need to handle exceptions when they happen
	// We don't want exceptions to break our code and prevent the file from being accessed in the rest of the application
	// We also don't want any developers to dispose a class 2 times by mistake
	class Program
	{
		#region Base implementation
		static string AppPath = @"..\..\..\Text";
		static string FilePath = AppPath + @"\text.txt";

		static void CreateFolder(string path)
		{
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
		}

		static void CreateFile(string path)
		{
			if (!File.Exists(path))
			{
				File.Create(path).Close();
			}
		}
		#endregion
		#region Manual Dispose Methods
		static void AppendTextInFile(string text, string path)
		{
			StreamWriter sw = new StreamWriter(path, true);
			// We are simulating that in the middle of executing our logic, something broke unexpectedly
			if (text == "break") throw new Exception("Something broke unexpectedly...");
			sw.WriteLine(text);
			sw.Dispose();
		}

		static void ReadTextFromFile(string path)
		{
			Console.WriteLine("-----------Read------------");
			StreamReader sr = new StreamReader(path);
			Console.WriteLine(sr.ReadToEnd());
			sr.Dispose();
		}

		// Instead of writing this code in the Main method of the console application
		// We write the code here in this method
		// We call this method then in the Main method 
		// We do this because we have multiple similar examples that do the same thing but differently implemented
		public static void ManualDisposeExample()
		{
			try
			{
				Console.WriteLine("Enter text pt1:");
				string text1 = Console.ReadLine();
				AppendTextInFile(text1, FilePath);
				Console.WriteLine("Enter text pt2:");
				string text2 = Console.ReadLine();
				AppendTextInFile(text2, FilePath);
				Console.WriteLine("Enter text pt3:");
				string text3 = Console.ReadLine();
				AppendTextInFile(text3, FilePath);
			}
			catch (Exception ex)
			{
				Console.WriteLine("There was a problem while writing in a file:");
				Console.WriteLine(ex.Message);
			}

			try
			{
				ReadTextFromFile(FilePath);

			}
			catch (Exception ex)
			{
				Console.WriteLine("There was a problem while reading from a file:");
				Console.WriteLine(ex.Message);
			}

			Console.ReadLine();
		}
		#endregion
		#region Disposing with Using Block
		static void AppendTextInFileSafely(string text, string path)
		{
			// This using block will call Dispose() when we get to the closing bracket of the code block ( this -> } )
			// The StreamWriter instance is only accessible in the using block and it is contained
			// Dispose() is called automatically
			// Only classes that inherit from IDisposable can use this feature
			using(StreamWriter sw = new StreamWriter(path, true))
			{
				// We are simulating that in the middle of executing our logic, something broke unexpectedly
				if (text == "break") throw new Exception("Something broke unexpectedly...");
				sw.WriteLine(text);
			}
		}

		static void ReadTextFromFileSafely(string path)
		{
			Console.WriteLine("-----------Read------------");
			using(StreamReader sr = new StreamReader(path))
			{
				Console.WriteLine(sr.ReadToEnd());
			}
		}

		// Instead of writing this code in the Main method of the console application
		// We write the code here in this method
		// We call this method then in the Main method 
		// We do this because we have multiple similar examples that do the same thing but differently implemented
		public static void UsingDisposeExample()
		{
			try
			{
				Console.WriteLine("Enter text pt1:");
				string text1 = Console.ReadLine();
				AppendTextInFileSafely(text1, FilePath);
				Console.WriteLine("Enter text pt2:");
				string text2 = Console.ReadLine();
				AppendTextInFileSafely(text2, FilePath);
				Console.WriteLine("Enter text pt3:");
				string text3 = Console.ReadLine();
				AppendTextInFileSafely(text3, FilePath);
			}
			catch (Exception ex)
			{
				Console.WriteLine("There was a problem while writing in a file:");
				Console.WriteLine(ex.Message);
			}

			try
			{
				ReadTextFromFileSafely(FilePath);

			}
			catch (Exception ex)
			{
				Console.WriteLine("There was a problem while reading from a file:");
				Console.WriteLine(ex.Message);
			}

			Console.ReadLine();
		}
		#endregion
		#region Dispose with our own class
		static void AppendTextInFileOur(string text, string path)
		{
			// This using block will call Dispose() when we get to the closing bracket of the code block ( this -> } )
			// The StreamWriter instance is only accessible in the using block and it is contained
			// Dispose() is called automatically
			// Only classes that inherit from IDisposable can use this feature
			using (OurWriter ow = new OurWriter(path))
			{
				// We are simulating that in the middle of executing our logic, something broke unexpectedly
				if (text == "break") throw new Exception("Something broke unexpectedly...");
				ow.Write(text);
			}
		}

		static void ReadTextFromFileOur(string path)
		{
			Console.WriteLine("-----------Read------------");
			using (OurReader or = new OurReader(path))
			{
				Console.WriteLine(or.Read());
			}
		}

		// Instead of writing this code in the Main method of the console application
		// We write the code here in this method
		// We call this method then in the Main method 
		// We do this because we have multiple similar examples that do the same thing but differently implemented
		public static void OurDisposeExample()
		{
			try
			{
				Console.WriteLine("Enter text pt1:");
				string text1 = Console.ReadLine();
				AppendTextInFileOur(text1, FilePath);
				Console.WriteLine("Enter text pt2:");
				string text2 = Console.ReadLine();
				AppendTextInFileOur(text2, FilePath);
				Console.WriteLine("Enter text pt3:");
				string text3 = Console.ReadLine();
				AppendTextInFileOur(text3, FilePath);
			}
			catch (Exception ex)
			{
				Console.WriteLine("There was a problem while writing in a file:");
				Console.WriteLine(ex.Message);
			}

			try
			{
				ReadTextFromFileOur(FilePath);

			}
			catch (Exception ex)
			{
				Console.WriteLine("There was a problem while reading from a file:");
				Console.WriteLine(ex.Message);
			}

			Console.ReadLine();
		}
		#endregion
		static void Main(string[] args)
		{
			CreateFolder(AppPath);
			CreateFile(FilePath);

			// Uncomment the example that you want to see and comment the others
			// ManualDisposeExample();
			// UsingDisposeExample();
			OurDisposeExample();
		}
	}
}
