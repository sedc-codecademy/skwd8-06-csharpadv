using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Authors
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(3.Add(5));


            var source = new AuthorRepo();
            var authors = source.GetAuthors();

            ////authors.Where(a => a.Name.StartsWith("A"));

            Action<int> printer = x => Console.WriteLine(x);

            Action<int, int> mulPrinter = (x, y) => Console.WriteLine(x * y);

            printer(3);
            printer(2 + 2);
            printer(3.Add(5));
            mulPrinter(3, 5);

            Action line = () => Console.WriteLine("-----------------------------");
            line();

            // DO NOT DO THIS - BAD PRACTICE
            Action<bool, bool, bool, bool> condPrinter = (isActive, isEnabled, isEven, isWeekday) =>
            {
                if (!isActive)
                {
                    Console.WriteLine("Inactive");
                }
                else if (isEnabled)
                {
                    if (isEven && isWeekday)
                    {
                        Console.WriteLine("Something else");
                    }
                    else
                    {
                        Console.WriteLine("Weekend");
                    }

                }
                else
                {
                    Console.WriteLine("Disabled");
                }
            };
            condPrinter(true, false, true, true);

            line();

            Action<string, int> repeat = (text, times) =>
            {
                for (int i = 0; i < times; i++)
                {
                    Console.Write(text);
                }
                Console.WriteLine();
            };

            repeat("weko", 5);

            line();

            Func<int, int, int> add = (x, y) => x + y;
            var z = add(4, 7);
            Console.WriteLine(z);



            Action<IEnumerable<Author>> authorPrinter = (collection) => {
                foreach (var author in collection)
                {
                    Console.WriteLine($"{author.Name}");
                }
                line();
            };

            // A - Authors

            Func<Author, bool> nameStartsWithA = author => author.Name.StartsWith("A");

            // var aauthors = Enumerable.Where(authors, nameStartsWithA);
            var aauthors = authors.Where(nameStartsWithA);

            authorPrinter(aauthors);

            // B - Authors

            Func<Author, bool> nameStartsWithB = author => author.Name.StartsWith("B");

            var bauthors = authors.Where(nameStartsWithB);

            authorPrinter(bauthors);

            // C - Authors

            Func<Author, bool> nameStartsWithC = GetNameLambdaForCharacter('C');

            var cauthors = authors.Where(nameStartsWithC);

            authorPrinter(cauthors);

            // D - Authors

            var dauthors = authors.Where(GetNameLambdaForCharacter('D'));
            authorPrinter(dauthors);

        }

        private static Func<Author, bool> GetNameLambdaForCharacter(char c)
        {
            Func<Author, bool> lambda = author => author.Name.StartsWith(c);
            return lambda;
        }
    }
}
