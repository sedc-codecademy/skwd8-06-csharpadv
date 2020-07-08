using System;
using System.Net;
using System.Threading;

namespace LittleThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            //WebClient wc = new WebClient();
            //var google = wc.DownloadString("http://www.facebook.com/");
            //Console.WriteLine(google);

            for (int index = 0; index < 45; index++)
            {
                var indexCopy = index;
                Action doCalculate = () =>
                {
                    Console.WriteLine($"Calculated fibonacci of {Fibonnacci(indexCopy)} for index {indexCopy} on thread {Thread.CurrentThread.ManagedThreadId} on processor {Thread.GetCurrentProcessorId()}");
                };

                //doCalculate();

                var thread = new Thread(new ThreadStart(doCalculate));
                thread.Start();
            }
        }

        static long Fibonnacci(int index)
        {
            if ((index == 0) || (index==1)) {
                return 1;
            }
            return Fibonnacci(index - 1) + Fibonnacci(index - 2);
        }
    }
}
