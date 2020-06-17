using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Adv.Class07.Anonymous
{
    class Program
    {
        public delegate void PrintString(string str);

        static void Main(string[] args)
        {
            #region old way with delegate
            // Old way of creating anonymuou methods
            //var example = new Example();

            //PrintString fnc = example.PrintStringInConsole;
            //fnc += example.PrintStringPlusOne;

            //for (int i = 0; i < 100; i++)
            //{
            //    fnc(i.ToString());
            //}
            #endregion

            #region Action
            Action welcomeMsg = () => Console.WriteLine("Welcome");
            // welcomeMsg();

            Action<string> hello = (str) => Console.WriteLine("Hello " + str);
            // hello("Trajan");

            Action<string, ConsoleColor> printMesssageWithColor = (str, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine("Hello " + str);
                Console.ResetColor();
            };
            // printMesssageWithColor("Tosho", ConsoleColor.DarkMagenta);

            Action<string, int, string, double, string, int, ConsoleColor> callWith7Params =
                (str, num, str1, dnum, str2, num1, color) =>
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine(str + num.ToString() + str1 + dnum.ToString() + str2 + num1.ToString());
                    Console.ResetColor();
                };
            // callWith7Params("str", 1, "str2", 3.3, "str3", 67, ConsoleColor.Yellow);
            #endregion

            #region Func

            Func<string> func = () => "Func has a return type of type string";
            Console.WriteLine(func());

            Func<int, int, int> sumOfInts = (num, num1) => num + num1;
            int result = sumOfInts(5, 2);
            Console.WriteLine(result);

            List<int> listOfNums = new List<int>() { 1, 2, 3, 4, 5 };
            Func<bool> isListEmpty = () => listOfNums.Count == 0;
            Console.WriteLine(isListEmpty());

            Func<int, int, bool> checkLarger = (num1, num2) =>
            {
                if(num1 > num2)
                {
                    return true;
                }
                return false;
            };
            Console.WriteLine(checkLarger(10, 2));
            Console.WriteLine(checkLarger(2, 10));
            #endregion

            #region LikeDelgate
            Action<string> fnc1 = str =>
            {
                string reverted = string.Join("", str.Reverse());
                Console.WriteLine(str.ToLower() == reverted.ToLower() ? "E palindrom" : "Ne e palindrom");
            };

            Action<string> fnc2 = str =>
            {
                Console.WriteLine($"Ima: {str.Split(' ').Length} zborovi");
            };

            Action<string> fnc3 = str =>
            {
                string reverted = string.Join("", str.Reverse());
                Console.WriteLine(reverted);
            };

            fnc1 += fnc2;
            fnc1 += fnc3;

            fnc1("Ana e radar");
            fnc1("Madam");
            #endregion

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var evenNumbers = list.Where(x => x % 2 == 0).ToList();

            Func<int, bool> getOddNumbers = num => num % 2 != 0;

            var oddNumbers = list.Where(getOddNumbers).ToList();

            list.FirstOrDefault<int>(x => x == 2);

            Func<int, Num> convertToNum = num => new Num() { Number = num };

            var result1 = list.Select(convertToNum).ToList();
            var result2 = list.Select(num => new Num() { Number = num }).ToList();

            var example1 = new Example();

            var listEx = example1.AddNToElementInList(list, (x, y) => x + y);

            Func<int, int, int> addNtoElement = (x, y) => x + y;

            var listEx1 = example1.AddNToElementInList(list, addNtoElement);

            Console.ReadLine();
        }
    }

    public class Example
    {
        public void PrintStringInConsole(string str)
        {
            Console.WriteLine(str);
        }

        public void PrintStringPlusOne(string str)
        {
            Console.WriteLine(str + "PlusOne");
        }

        public List<int> AddNToElementInList(List<int> list, Func<int, int, int> func)
        {
            List<int> newList = new List<int>();
            foreach (var item in list)
            {
                int result = func(item, 10);
                newList.Add(result);
            }
            return newList;
        }
    }

    public class Num
    {
        public int Number { get; set; }
    }
}
