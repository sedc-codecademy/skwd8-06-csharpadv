using System;
using System.Threading;

namespace Finalizer
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                var p = new Person { FirstName = "Wekoslav", LastName = "Stefanovski" };
            }
            
            GC.Collect();
        }
    }
}
