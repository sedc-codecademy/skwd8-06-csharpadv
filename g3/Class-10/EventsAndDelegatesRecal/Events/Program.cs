using System;
using System.Diagnostics;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted;
            bl.ProcessCompleted += bl1_ProcessCompleted;
            bl.ProcessCompleted += bl2_ProcessCompleted;
            bl.ProcessCompleted += bl3_ProcessCompleted;
            bl.ProcessCompleted += bl4_ProcessCompleted;
            
            
            bl.StartProcess();

            bl.ProcessCompleted -= bl4_ProcessCompleted;

            bl.StartProcess();

            Console.ReadKey();
        }

        private static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed");
        }
        private static void bl1_ProcessCompleted()
        {
            Console.WriteLine("Process Completed 2");
        }
        private static void bl2_ProcessCompleted()
        {
            Console.WriteLine("Process Completed 3");
        }
        private static void bl3_ProcessCompleted()
        {
            Console.WriteLine("Process Completed 4");
        }
        private static void bl4_ProcessCompleted()
        {
            Console.WriteLine("Process Completed 5");
            Console.WriteLine("Process Completed 5");
            Console.WriteLine("Process Completed 5"); 
            Console.WriteLine("Process Completed 5");
            Console.WriteLine("Process Completed 5");
            Console.WriteLine("Process Completed 5");
        }
    }
}
