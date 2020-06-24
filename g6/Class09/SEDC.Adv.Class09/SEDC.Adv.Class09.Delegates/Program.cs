using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Adv.Class09.Delegates
{
    //access modifier - delegate keyword - return type - identifier - ([parameters])
    public delegate void SayHello();
    class Program
    {
        public delegate void ShowMessage(string msg, string str);
        public delegate int SumDelegate(int num, int num1);

        public delegate bool Filter(int x);

        static void Main(string[] args)
        {
            SayHello sayHello = new SayHello(WelcomeMessage);
            SayHello sayHello1 = new SayHello(SaySomething);

            //sayHello();
            //sayHello1();

            var example = new Example();

            ShowMessage showMessage = new ShowMessage(example.PrintMessage);
            SumDelegate sumDelegate = new SumDelegate(example.SumOfTwoNumbers);

            //showMessage("Some message here ...", "Trajan");
            //var sum = sumDelegate(4, 8);
            //Console.WriteLine(sum);

            SayHello sayHello2 = new SayHello(() => Console.WriteLine("Anonymous function in delegate"));
            ShowMessage showMessage1 = 
                new ShowMessage((x, y) => Console.WriteLine($"Im x with value {x}, im y with value {y}"));
            SumDelegate sumDelegate1 = new SumDelegate((x, y) => x - y);
            SumDelegate sumDelegate2 = new SumDelegate((x, y) =>
            {
                return x - y;
            });

            //sayHello2();
            //showMessage1("You have new message", "Tosho");
            //int result = sumDelegate1(10, 6);
            //Console.WriteLine(result);

            Action action = () => Console.WriteLine("Im action");
            SayHello actionParam = new SayHello(action);

            ShowMessage showMessage10 =
                new ShowMessage((x, y) => Console.WriteLine($"Im x with value {x}, im y with value {y}"));
            showMessage10 +=
                new ShowMessage((x, y) => Console.WriteLine($"Second fnc Im x with value {x}, im y with value {y}"));

            showMessage10("Im x", "Im y");
            
            Filter filter = new Filter(x => x % 2 == 0);

            List<int> listOfIntegers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var result = listOfIntegers.Where(x => x % 2 == 0).ToList();
            var result1 = listOfIntegers.Where(x => filter(x)).ToList();

            PrintNumbers(listOfIntegers, filter);


            Console.ReadLine();
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome");
        }

        static void SaySomething()
        {
            Console.WriteLine("Say something");
        }

        static void PrintNumbers(List<int> list, Filter filter)
        {
            foreach (var item in list)
            {
                if (filter(item))
                {
                    Console.WriteLine($"{item} is Even");
                }
                else
                {
                    Console.WriteLine($"{item} is Odd");
                }
            }
        }
    }
}
