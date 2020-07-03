using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ResourceHog
{
    public class WithResource : IDisposable
    {
        private string resource = string.Empty;
        public string Resource {
            get 
            { 
                if (string.IsNullOrEmpty(resource))
                {
                    throw new Exception("Resource is not opened");
                }
                return resource;
            }
        }

        public WithResource()
        {
        }
        public void Open()
        {
            Console.WriteLine("Allocating the resource");
            Thread.Sleep(100);
            resource = "I'm the resource";
        }

        public void Close()
        {
            Console.WriteLine("Clearing the resource");
            Thread.Sleep(100);
            resource = string.Empty;
        }

        public void Dispose()
        {
            Close();
        }
    }
}
