using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.ClassDispose.Disposing
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
            if (text.Contains("break"))
                throw new Exception("Something broke in our custome writer!");
            _sw.WriteLine(text);
        }


        //We implement this private method that will remember when this class is disposed
        //That way, if the same class tries to get disposed again, all the Dispose() methods will not get called
        private void _dispose(bool disposing)
        {
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

        //This method must be implemented, because it comes from the IDisposable interface
        //We can implement this method alone and add the disposing here
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


        //We implement this private method that will remember when this class is disposed
        //That way, if the same class tries to get disposed again, all the Dispose() methods will not get called
        private void _dispose(bool disposing)
        {
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


        public void Dispose()
        {
            _dispose(true);
        }
    }
}
