using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Class11.Disposing
{
    public class Ourwriter : IDisposable
    {
        private string path;

        private StreamWriter _sw;

        private bool disposedValue = false;

        public Ourwriter(string filePath)
        {
            path = filePath;
            _sw = new StreamWriter(path, true);
        }
        public void Write(string text)
        {
            if (text == "break") throw new Exception("Something broke unexpectedly..");
            _sw.WriteLine(text);
        }
        private void _dispose(bool disposing)
        {
            if(!disposedValue)
            {
                if (disposing)
                {
                    _sw.Dispose();
                }
                disposedValue = true;
                path = "";
            }
        }
        public void Dispose()
        {
            _dispose(true);
        }
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

        private void _dispose(bool disposing)
        {
            if(!disposedValue)
            {
                if(disposing)
                {
                    _sr.Dispose();
                }

                disposedValue = true;
                path = "";
            }
        }

        public void Dispose()
        {
            _dispose(true);
        }
    }
}
