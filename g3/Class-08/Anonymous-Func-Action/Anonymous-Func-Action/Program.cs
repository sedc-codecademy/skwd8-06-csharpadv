using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_Func_Action
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<string> names = new List<string>()
            {
                "Alek", "Deki", "Andrej", "Andreja", "Anita", "Miki"
            };
            List<string> empty = new List<string>();

            #region Func
            //in javascript let funk = x => x.Id == id;
            Func<bool> isNameEmptyStandard = new Func<bool>(isEmpty);
            Console.WriteLine($"isNameEmptyStandard: { isNameEmptyStandard()}");

            Func<bool> isNameEmpty = () => names.Count == 0;
            Console.WriteLine($"isNameEmpty: { isNameEmpty()}");

            Func<List<string>, bool> isListEmpty = (list) => list.Count == 0;
            Console.WriteLine($"isListEmpty: {isListEmpty(names)}");

            Func<int, int, bool> checkLarger = (x, y) => {
                if (x > y) return true;
                return false;
            };
            Console.WriteLine($"CheckLarger: { checkLarger(5, 4)}");
            #endregion

            #region Func2
            //// Regular function definition
            //function multiplyByTwo(num) {
            //    return num * 2;
            //}

            //// Function expression
            // let multiplyByTwo = function(num) {
            //      return num * 2
            // }

            //// Arrow functions
            // let multiplyByTwo = num => num * 2;

            // Use Func<> when you want to define a function that returns a value
            Func<int, int> multiplyByTwo = num => num * 2; // In Func<> the last type parameter is always the return type
            Func<int, int> multiplyByThree = num =>
            {
                return num * 3;
            }; // In Func<> the last type parameter is always the return type

            Func<int, int, int> multiplyBy = new Func<int, int, int>((num, by) => num * by); // In Func<> the last type parameter is always the return type
            #endregion

            #region Action
            // Use Action<> when you want to defaine a function that returns void
            Action<int> printNum = num => Console.WriteLine(multiplyByTwo(num)); // In Action<> every type parameter is a function parameter, there is no return type
            Action<int, int> multiplyByVoid = (num, by) => multiplyBy(num, by); // If you notice we are using lambda expression without body, this means whatever it is after the => it's returned, BUT since we are using Action<> that rule DOES NOT apply in here, the value it's not returned
            Action<int> div = num =>
            {
                Divide(num); // This is how it looks if multiplyByVoid had a body, it's not returning anything
                //return Divide(num); // If it was Func<> it would look like this, the lambda without body would look like this
            };
            #endregion

            names.Select(name => name + "123"); // Using Func<> in LINQ

            names.ForEach(name => Console.WriteLine(name + "123")); // using Action<> in LINQ

            Console.ReadKey();
        }
        private static double Divide(int num)
        {
            return num / 2;
        }
        private static bool isEmpty()
        {
            List<string> names = new List<string>()
            {
                "Alek", "Deki", "Andrej", "Andreja", "Anita", "Miki"
            };
            if (names.Count == 0)
                return true;
            return false;
        }
    }
}
