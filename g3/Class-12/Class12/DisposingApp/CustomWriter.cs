using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DisposingApp
{
    public class CustomWriter : IDisposable
    {
        private StreamWriter _writer { get; set; }

        public CustomWriter(Stream stream)
        {
            _writer = new StreamWriter(stream);
        }

        public void Write(string content)
        {
            _writer.Write("[From CustomWriter] " + content);
        }

        public void WriteLine(string content)
        {
            _writer.WriteLine("[From CustomWriter] " + content);
        }

        public void Dispose()
        {
            Console.WriteLine("This class is disposed");
            _writer.Dispose();
        }
    }
}
