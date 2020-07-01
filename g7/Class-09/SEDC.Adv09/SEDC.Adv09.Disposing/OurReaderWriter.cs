using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.Adv09.Disposing
{
	// We will try and build our own disposable class where we will dispose the StreamReader and StreamWriter our selves
	// These are examples of how to build custom disposable classes
	// The example is with StreamReader and StreamWriter as an external connection
	// You can easily implement this but instead of StreamReader or StreamWriter use some other extranl source ( DB, API .. )
	public class OurWriter : IDisposable
	{
		#region Main Logic
		private string _path;
		private StreamWriter _sw;

		public OurWriter(string filePath)
		{
			_path = filePath;
			_sw = new StreamWriter(_path, true);
		}

		public void Write(string text)
		{
			// In another case here there would be writing in a table of a database
			// In another case here there would be an http post request on an open connection to an API
			if(text == "break") throw new Exception("Something broke unexpectedly...");
			_sw.WriteLine(text);
		}
		#endregion
		#region Dispose Logic
		// This private field keeps track if the class got disposed 
		// If it is true, the _dispose() method will not dispose the class again
		private bool _isDisposed = false;

		// This method decides whether it disposes the class or not
		// If the variable _isDisposed is false, then it closes the connection and removes all values from the properties
		// It also sets the _isDisposed to true so in the future we can't Dispose again 
		private void _dispose(bool disposing)
		{
			// This will not work since we try to call a method on nothing
			// The same logic can apply to calling Dispose() or Close() method on nothing
			// List<string> list; // null
			// list.Add("Bob"); // null.Add("Bob") -> This will not work

			// We are the developer
			// OurWriter.Dispose() -> We do this at some point in our code
			// Now OurWriter is disposed
			// Then we write a lot of lines of code
			// Our coworker comes and continues with the code
			// They don't see that you already Disposed the class so they try and call OurWriter.Dispose() again
			// At that point, the class is already disposed by you and it is empty
			// Your coworker will get an error because they didn't know that they were calling Dispose() on an empty connection

			if (!_isDisposed)
			{
				if (disposing)
				{
					_sw.Dispose();
				}
				_path = "";
				_isDisposed = true;
			}
		}

		// This is a Dispose() method that comes from IDisposable
		// We can later call it manually or we can use this class in a using block
		// This method calls a private _dispose() method so that it can make sure that this class is not disposed multiple times
		public void Dispose()
		{
			_dispose(true);
		}

		#endregion
	}

	public class OurReader : IDisposable
	{
		#region Main Logic
		private string _path;
		private StreamReader _sr;

		public OurReader(string filePath)
		{
			_path = filePath;
			_sr = new StreamReader(_path);
		}

		public string Read()
		{
			return _sr.ReadToEnd();
		}
		#endregion
		#region Dispose Logic
		// This private field keeps track if the class got disposed 
		// If it is true, the _dispose() method will not dispose the class again
		private bool _isDisposed = false;

		// This method decides whether it disposes the class or not
		// If the variable _isDisposed is false, then it closes the connection and removes all values from the properties
		// It also sets the _isDisposed to true so in the future we can't Dispose again 
		private void _dispose(bool disposing)
		{
			// This will not work since we try to call a method on nothing
			// The same logic can apply to calling Dispose() or Close() method on nothing
			// List<string> list; // null
			// list.Add("Bob"); // null.Add("Bob") -> This will not work

			// We are the developer
			// OurWriter.Dispose() -> We do this at some point in our code
			// Now OurWriter is disposed
			// Then we write a lot of lines of code
			// Our coworker comes and continues with the code
			// They don't see that you already Disposed the class so they try and call OurWriter.Dispose() again
			// At that point, the class is already disposed by you and it is empty
			// Your coworker will get an error because they didn't know that they were calling Dispose() on an empty connection

			if (!_isDisposed)
			{
				if (disposing)
				{
					_sr.Dispose();
				}
				_path = "";
				_isDisposed = true;
			}
		}

		// This is a Dispose() method that comes from IDisposable
		// We can later call it manually or we can use this class in a using block
		// This method calls a private _dispose() method so that it can make sure that this class is not disposed multiple times
		public void Dispose()
		{
			_dispose(true);
		}

		#endregion
	}
}
