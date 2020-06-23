using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

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
            Console.WriteLine($"CheckLarger: { checkLarger(5,4)}");
            #endregion

            #region Action

            #endregion

            Console.ReadKey();
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
        private static bool isFull()
        {
            return true;
        }
        private static bool isSomething()
        {
            return false;
        }

        //private static bool isEmpty(List<string>)
        //{

        //}
    }
}
