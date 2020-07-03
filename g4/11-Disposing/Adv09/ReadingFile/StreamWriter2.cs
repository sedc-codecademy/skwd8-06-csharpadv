using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadingFile
{
    public class StreamWriter2 : StreamWriter, IDisposable
    {
        public StreamWriter2(string path) : base(path)
        {

        }

        public new void Dispose()
        {
            Console.WriteLine("Dispose is called");
            base.Dispose();
        }

        // override  
    }
}
