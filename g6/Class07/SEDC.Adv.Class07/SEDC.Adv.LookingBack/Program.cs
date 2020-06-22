using System;

namespace SEDC.Adv.LookingBack
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();

            // logger.LogError("Error message");

            // logger.LogError("error message", true);

            // logger.LogError("ERRROE Message", ConsoleColor.Yellow);

            // logger.LogError("ERRROE Message", ConsoleColor.Yellow, true);

            // logger.LogInfo("Some info message");

            //var student = new Student() { FirstName = "Trajan", LastName = "Stevkovski", Age = 33, IsPartTime = true };
            //Console.WriteLine(student.ToString());


            //StaticLogger.PrintId();

            //for (int i = 0; i < 100; i++)
            //{
            //    StaticLogger.PrintId();
            //}

            logger.LogWarning("this is a warning");

            logger.LogInfo("this is info");

            logger.LogError("this is error");


            Console.ReadLine();
        }
    }
}
