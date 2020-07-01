using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SEDC.Adv.Class11.Disposing
{
    public class OurWriter : IDisposable
    {
        private string _path;
        private StreamWriter _sw;

        private bool _disposedValue = false;

        public OurWriter(string filePath)
        {
            _path = filePath;
            _sw = new StreamWriter(filePath, true);
        }

        public void Write(string text)
        {
            if (text == "break")
            {
                throw new Exception("Something went wrong...");
            }
            _sw.WriteLine(text);
        }

        private void _dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                {
                    _sw.Dispose();
                }

                _path = string.Empty;
                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            _dispose(true);
        }
    }

}
