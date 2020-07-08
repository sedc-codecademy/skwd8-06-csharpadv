using System;

namespace SEDC.Adv.Class11.NamedAndOptionalParams
{
    class Program
    {
        static void Main(string[] args)
        {
            //WriteInConsole("Hello from SEDC");

            //WriteInConsoleOptional();

            //WriteInConsoleOptional("Hello from SEDC");

            //WriteInConsoleThirdWay("Hello from SEDC");
            //Console.ReadLine();

            //WriteInConsoleThirdWay("Hello from SEDC", ConsoleColor.Red);
            //Console.ReadLine();

            //WriteInConsoleThirdWay("Hello from SEDC", ConsoleColor.Blue, ConsoleColor.Cyan);
            //Console.ReadLine();

            //WriteInConsoleThirdWay("Hello from SEDC", ConsoleColor.Green, ConsoleColor.Yellow, true);

            WriteInConsoleThirdWay("Hello from", showSedcAtEnd: true);


            // this was is ok
            WriteInConsoleThirdWay(showSedcAtEnd: true, msg: "Hello from Msg as named param");

            // this is not ok 
            //WriteInConsoleThirdWay(showSedcAtEnd: true, "Hello from Msg as named param");

            //WriteInConsoleThirdWay(msg: "Named param 1", showSedcAtEnd: false, ConsoleColor.Red);

            //WriteInConsoleThirdWay("Unnamed param", ConsoleColor.Yellow, showSedcAtEnd: true, foregroundColor: ConsoleColor.Blue);

            //WriteInConsoleOtherWay("Hello From Sedc", null, null, true);

            Console.ReadLine();
        }

        public static void WriteInConsole(string msg)
        {
            Console.WriteLine(msg);
        }

        public static void WriteInConsoleOptional(string msg = "SEDC")
        {
            Console.WriteLine(msg);
            // some logic here
        }

        public static void WriteInConsoleThirdWay(string msg, // required
            ConsoleColor backgroundColor = ConsoleColor.Black, // optional
            ConsoleColor foregroundColor = ConsoleColor.White, // optional
            bool showSedcAtEnd = false) // optional
        {
            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;

            if (showSedcAtEnd)
            {
                msg = $"{msg} SEDC";
            }
            Console.WriteLine(msg);
        }

        public static void WriteInConsoleOtherWay(string msg, // required
            ConsoleColor? backgroundColor = ConsoleColor.Black, // optional
            ConsoleColor? foregroundColor = ConsoleColor.White, // optional
            bool? showSedcAtEnd = false) // optional
        {
            if (backgroundColor.HasValue)
            {
                Console.BackgroundColor = backgroundColor.Value;
            }

            if (foregroundColor.HasValue)
            {
                Console.ForegroundColor = foregroundColor.Value;
            }

            if (showSedcAtEnd.HasValue)
            {
                if (showSedcAtEnd.Value)
                {
                    msg = $"{msg} SEDC";
                }
            }

            Console.WriteLine(msg);
        }
    }
}
