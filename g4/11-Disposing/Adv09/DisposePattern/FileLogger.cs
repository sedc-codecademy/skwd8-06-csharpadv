using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DisposePattern
{
    class FileLogger: IDisposable
    {
        private StreamWriter writer;

        public string LogFile { get; private set; }
        public FileLogger(string logfile)
        {
            LogFile = logfile;
            writer = new StreamWriter(LogFile, true);
        }

        public void Info(string message)
        {
            writer.WriteLine($"[INFO] {message}");
        }

        public void Error(string message)
        {
            writer.WriteLine($"[ERROR] {message}");
        }

        public void Error(Exception exception, string message = "")
        {
            writer.WriteLine($"[ERROR] {exception.Message} {message}");
        }

        #region Dispose
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Console.WriteLine("Dispose is called");
                    writer.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

         // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
         ~FileLogger()
         {
             // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
             Dispose(disposing: false);
         }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        //public void Dispose()
        //{
        //    Console.WriteLine("Dispose is called");
        //    writer.Dispose();
        //}
        #endregion

    }
}
