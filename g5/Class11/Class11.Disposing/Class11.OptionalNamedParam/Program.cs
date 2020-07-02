using System;

namespace Class11.OptionalNamedParam
{
    class Program
    {
        static void CheckOperation(int num1, int num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"{num1} {operation} {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} {operation} {num2} = {num1 - num2}");
                    break;
                default:
                    Console.WriteLine($"The app does not work with {operation}");
                    break;
            }
        }
        static void NoOptional(int num1, int num2, string operation)
        {
            CheckOperation(num1, num2, operation);
        }

        static void SomeOptional(int num1,int num2, string operation = "+")
        {
            CheckOperation(num1, num2, operation);
        }

        static void AllOptional(int num1 = 5, int num2 = 10, string operation = "+")
        {
            CheckOperation(num1, num2, operation);
        }
        static void Main(string[] args)
        {
            NoOptional(2, 3,"+");
            SomeOptional(2, 3);
            SomeOptional(10, 5, "-");
            AllOptional();
            AllOptional(1);
            AllOptional(1, 5);
            AllOptional(12, 5, "-");
            AllOptional(num2: 3);
            NoOptional(num2: 3, operation: "+", num1: 10);
            NoOptional(10, operation: "-", num2: 3);
            //NoOptional(operation: "+",2, 4);
            Console.ReadLine();
        }
    }
}
