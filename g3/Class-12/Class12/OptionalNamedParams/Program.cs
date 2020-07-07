using System;
using System.Net.Http.Headers;

namespace OptionalNamedParams
{
    class Program
    {
        static void CheckOperator(int num1, int num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{num1} {operation} {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} {operation} {num2} = {num1 + num2}");
                    break;
                default:
                    Console.WriteLine($"This app does not work with this operation: {operation}");
                    break;
            }
        }
        static void NoOptional(int num1, int num2, string operation)
        {
            CheckOperator(num1, num2, operation);
        }
        static void SomeOptional(int num1, int num2, string operation = "+")
        {
            CheckOperator(num1, num2, operation);
        }
        static void AllOptional(int num1 = 2, int num2 = 3, string operation = "+")
        {
            CheckOperator(num1, num2, operation);
        }
        static void Main(string[] args)
        {
            #region Simple Examples from class
            //Console.WriteLine("Hello World!");
            int alek = 1;
            string alek2 = "";
            SomeMethod(alek, alek2);


            NoOptional(2, 3, "-");
            SomeOptional(2, 5);
            AllOptional(3, operation: "-");

            int num2Arg = 5;

            NoOptional(operation: "-", num1:3, num2: num2Arg);
            //AllOptional(3, operation: "5", 5); //will not work
            #endregion

            #region More Examples
            NoOptional(2, 3, "+");
            // NoOptional(2, 3); // Will not work since the last is not optional
            SomeOptional(2, 3);
            SomeOptional(5, 3, "-");
            AllOptional();
            AllOptional(1);
            AllOptional(1, 5);
            AllOptional(12, 5, "-");

            NoOptional(num2: 3, operation: "+", num1: 10);
            NoOptional(10, operation: "-", num2: 3); // We can leave some unnamed argumens as long as their order is correct
            // NoOptional(operation: "+", 2, 4); // We can only do random order if ALL arguments are named

            Console.ReadLine();
            #endregion
        }

        private static void SomeMethod(int alekInt, string alekStr)
        {
            throw new NotImplementedException();
        }
    }
}
