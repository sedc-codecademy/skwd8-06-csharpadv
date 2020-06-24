using System;
using System.Collections.Generic;

namespace Class08.Delegates
{
    class Program
    {
        /// <summary>
        /// This delegate Filters is regarding the First Example
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public delegate bool Filters(string name);

        /// <summary>
        /// These two delegates are regarding the Second Example
        /// </summary>
        /// <param name="something"></param>
        public delegate void SayDelegate(string something);
        public delegate int NumbersDelegate(int num1, int num2);
        static void Main(string[] args)
        {
            /********* First Part ********/
            #region First Example
            string[] names = { "Alice", "John", "Bobby", "Scott", "Tim", "Sharon", "Armin", "George" };
            List<string> lessThanFiveChars = NamesFilter(names,x => x.Length == 5);

            foreach (var item in names)
            {
                if(item.Length < 5)
                {
                    lessThanFiveChars.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", lessThanFiveChars));


            static List<string> NamesFilter(string[] names,Filters filter)
            {
                List<string> result = new List<string>();
                foreach (var item in names)
                {
                    if (item.Length == 5)
                    {
                        result.Add(item);
                    }
                }
                return result;
            }

            static bool LessThanFive(string name)
            {
                return name.Length < 5;
            }
            static bool MoreThanFive(string name)
            {
                return name.Length > 5;
            }
            static bool ExactFive(string name)
            {
                return name.Length == 5;
            }
            #endregion

            /********* Second Part ********/
            #region Second Exmaple
            SayDelegate del = new SayDelegate(SayHello);
            SayDelegate bye = new SayDelegate(SayBye);
            SayDelegate wow = new SayDelegate(x => Console.WriteLine($"WOW {x}"));

            del("Bob");
            del += SayBye;
            del("Andrej");
            bye("Jill");
            wow("Greg");

            foreach (var d in del.GetInvocationList())
            {
                Console.WriteLine(d.Method);
            }

            SayWhatever("Bob", SayHello);
            SayWhatever("Jill", SayBye);
            SayWhatever("Anne", x =>
            {
                Console.WriteLine($"Stuff with {x}");

            });

            NumbersMaster(2, 5, (x, y) => x + y);
            NumbersMaster(2, 5, (x, y) => x - y);
        }

        public static void NumbersMaster(int num1, int num2, NumbersDelegate numberDel)
        {
            Console.WriteLine($"The result is : {numberDel(num1,num2)}");
        }

        public static void SayWhatever(string whatever, SayDelegate sayDel)
        {
            Console.WriteLine("Chatbot says: ");
            sayDel(whatever);
        }

        public static void SayHello(string person)
        {
            Console.WriteLine($"Hello {person}");
        }

        public static void SayBye(string person)
        {
            Console.WriteLine($"Bye {person}");
        }

        #endregion


    }
}
