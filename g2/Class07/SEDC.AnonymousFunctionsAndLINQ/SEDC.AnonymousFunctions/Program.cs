using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.AnonymousFunctions
{
    class Program
    {

        public static void Greet()
        {
            Console.WriteLine("Hello I am a regular method!");
        }

        public static void CheckResult(int num1, int num2, Func<int, int, int> func)
        {
            int result = func(num1, num2);
            if(result > 0)
            {
                Console.WriteLine("The result is: " + result);
            }
            else
            {
                Console.WriteLine("The result is less than 0!");
            }
        }

        static void Main(string[] args)
        {
            #region Lambda expression
            //Lambda expression
            List<string> names = new List<string>() { "Martin", "Dejan", "Ivo" };
            List<string> emptyList = new List<string>();
            string foundDejan = names.Find(x => x == "Dejan");
            #endregion

            #region Func

            //Func always returns value

            //Example of a Func with no input parameters
            Func<bool> isPresent = () =>
            {
                return names.Any(x => x == "Martin");
            };

            Func<bool> isFound = () => names.Any(x => x == "Ivo");

            Console.WriteLine(isPresent());
            if (isFound())
            {
                Console.WriteLine("Hi Ivo!");
            }


            //Example of Func with on or more input parameters

            Func<int, int, int> sum = (x, y) => x + y;
            Func<int, int, int> multiply = (x, y) => x * y;
            Console.WriteLine(sum(10, 15));
            Console.WriteLine(sum(10, 123));
            Console.WriteLine(sum(45, 123));


            Func<List<string>, bool> isListEmpty = (list) => list.Count() == 0;
            if (isListEmpty(names))
            {
                Console.WriteLine("List of names is empty!");
            }
            else if (isListEmpty(emptyList))
            {
                Console.WriteLine("Empty list of course is empty!");
            }

            Func<int, int, int, int> findMax = (x, y, z) => new List<int>() { x, y, z }.Max();
            //{
                //return new List<int>() { x, y, z }.Max();

                //if(x > y && x > z)
                //{
                //    return x;
                //}
                //else if(y > x && y > z)
                //{
                //    return y;
                //}
                //else
                //{
                //    return z;
                //}
            //};

            Console.WriteLine("The max value is: ");
            Console.WriteLine(findMax(10, 100, 13));
            #endregion

            Console.WriteLine("======================== ACTION ==========================");

            #region Action
            //Example of Action without input parameters
            Action greet = () => Console.WriteLine("Hello from Action!");
            greet();


            //Example of Action with one or more input parameters
            Action<string> printRed = x =>
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(x);
                Console.ResetColor();
            };
            printRed("An error occured!");


            Action<string, ConsoleColor> printMessage = (message, color) =>
            {
                Console.ForegroundColor = color;
                Console.WriteLine(message);
                Console.ResetColor();
            };
            printMessage("It is a warning, it's okay!", ConsoleColor.Yellow);
            printMessage("It is an ERROR!", ConsoleColor.Red);









            #endregion

            Greet();

            Console.WriteLine("======================== Func and Action as callbacks ==========================");

            #region Action and Func used as callbacks
            CheckResult(15, 20, sum);
            CheckResult(15, 0, multiply);
            #endregion


            #region Higher order Function Use

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 10, 12, 22, 100 };
            List<string> animals = new List<string>() { "Elephant", "Lion", "Monkey", "Snake", "Eagle" };

            Func<int, bool> isGreaterThanTen = x => x > 10;
            Func<string, bool> isLion = animal => animal == "Lion";

            ////Call of Any() by only pointing(referencing) to isLion
            bool foundLion = animals.Any(isLion);
            if (foundLion)
            {
                Console.WriteLine("Wooohooo! Lion found!");
            }
            else
            {
                Console.WriteLine("Try again next time!");
            }


            //Regular call of Any()
            numbers.Any(x => x > 10);

            //Call of Any() by invoking isGreaterThanTen() with parameter
            numbers.Any(x => isGreaterThanTen(x));

            //Call of Any() by only pointing(referencing) to isGreaterThanTeh
            numbers.Any(isGreaterThanTen);


            string elephant = animals.First();
            Func<string, bool> startsWithE = x => x.StartsWith("E");

            List<string> animalsStartsWithE = animals.Where(startsWithE).ToList();
            Console.WriteLine("Animals that starts with letter 'E'");
            foreach (var animal in animalsStartsWithE)
            {
                Console.WriteLine(animal);
            }

            bool isElephant = startsWithE(elephant);
            if (isElephant)
            {
                Console.WriteLine("Yeah! The animal starts with letter 'E'");
            }
            else
            {
                Console.WriteLine("Nope! The animal doesn't starts with letter 'E'");
            }


            #endregion





            Console.ReadLine();
        }
    }
}
