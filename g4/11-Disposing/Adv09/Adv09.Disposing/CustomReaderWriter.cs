﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Adv09.Disposing
{
	public class OurWriter : IDisposable
	{
        private string path;

        private StreamWriter _sw;

        private bool disposedValue = false;

		public OurWriter(string filePath)
		{
            path = filePath;
            _sw = new StreamWriter(path, true);
		}
        public void Write(string text)
		{
            if (text == "break") throw new Exception("Something broke unexpectedly...");
            _sw.WriteLine(text);
        }
		#region Dispose Implementation
		// We implement this private method that will remember when this class is disposed
		// That way, if the same class tries to get disposed again, all the Dispose() methods will not get called
		private void _dispose(bool disposing)
        {
            // This happens only when the class needs to be disposed the first time
            if (!disposedValue)
            {
                if (disposing)
                {
                    _sw.Dispose();
                }

                path = "";
                disposedValue = true;
            }
        }
        // We can implement this method alone and add the disposing here
        public void Dispose()
        {
            _dispose(true);
        }
		#endregion
	}

    public class OurReader : IDisposable
    {
        private string path;

        private StreamReader _sr;

        private bool disposedValue = false;

        public OurReader(string filePath)
        {
            path = filePath;
            _sr = new StreamReader(path);
        }
        public string Read()
        {
            return _sr.ReadToEnd();
        }
        #region Dispose Implementation
        // We implement this private method that will remember when this class is disposed
        // That way, if the same class tries to get disposed again, all the Dispose() methods will not get called
        private void _dispose(bool disposing)
        {
            // This happens only when the class needs to be disposed the first time
            if (!disposedValue)
            {
                if (disposing)
                {
                    _sr.Dispose();
                }

                path = "";
                disposedValue = true;
            }
        }
        // We can implement this method alone and add the disposing here
        public void Dispose()
        {
            _dispose(true);
        }
        #endregion
    }
}
