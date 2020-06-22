﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
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
                foreach (var author in collection.Take(3))
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

            // F - Authors

            // ADVANCED, CAUSES BRAIN HURT
            // Func<char, Func<Author, bool>> nameStartsWith = c => author => author.Name.StartsWith(c);

            int countExec = 0;

            Func<char, Func<Author, bool>> nameStartsWith = c => {
                return author =>
                {
                    countExec += 1;
                    Console.WriteLine($"I've been called for {author.Name}");
                    return author.Name.StartsWith(c);
                };
            };

            var firstAuthor = authors.First();
            var isFirstAuthorWithAnF = nameStartsWith('F')(firstAuthor);
            var isFirstAuthorWithAnD = GetNameLambdaForCharacter('D')(firstAuthor);
            line();

            Console.WriteLine("BEFORE WHERE");

            var fauthors = authors.Where(nameStartsWith('C'));

            var fauthorName = fauthors.Select(f => f.Name).ToList();

            Console.WriteLine("AFTER WHERE; BEFORE PRINT");

            authorPrinter(fauthors);

            Console.WriteLine(countExec);

            line();

            // E - Authors
            var startsWithE = GetStartsWithLambda<Author>('E', a => a.Name);
            var eauthors = authors.Where(startsWithE);
            authorPrinter(eauthors);

            var allBooks = authors.SelectMany(a => a.Books);

            Console.WriteLine(allBooks.Count());

            Action<IEnumerable<Book>> bookPrinter = (collection) => {
                foreach (var book in collection)
                {
                    Console.WriteLine($"{book.Title}");
                }
                line();
            };

            line();

            // A - Books
            var bookStartsWithA = GetStartsWithLambda<Book>('A', b => b.Title);
            var abooks = allBooks.Where(bookStartsWithA);
            bookPrinter(abooks);

            // Advanced Advanced - Hurts Lecturers Brain

            //var bookStartsWithB = GetStartsWithLambda<Book>('B', b => b.Title);
            //var bookStartsWithC = GetStartsWithLambda<Book>('C', b => b.Title);
            //var bookStartsWithD = GetStartsWithLambda<Book>('D', b => b.Title);
            //var bookStartsWithE = GetStartsWithLambda<Book>('E', b => b.Title);
            //var bookStartsWithF = GetStartsWithLambda<Book>('F', b => b.Title);

            //var bookStartsWithB = GetTitleLambdaForCharacter('B');
            //var bookStartsWithC = GetTitleLambdaForCharacter('C');
            //var bookStartsWithD = GetTitleLambdaForCharacter('D');
            //var bookStartsWithE = GetTitleLambdaForCharacter('E');
            //var bookStartsWithF = GetTitleLambdaForCharacter('F');

            var getTitleLambdaForCharacter = GetStartsWithLambdaGenerator<Book>(b => b.Title);

            var bookStartsWithB = getTitleLambdaForCharacter('B');
            var bookStartsWithC = getTitleLambdaForCharacter('C');
            var bookStartsWithD = getTitleLambdaForCharacter('D');
            var bookStartsWithE = getTitleLambdaForCharacter('E');
            var bookStartsWithF = getTitleLambdaForCharacter('F');
            
            bookPrinter(allBooks.Where(bookStartsWithF));
        }

        private static Func<Author, bool> GetNameLambdaForCharacter(char c)
        {
            Func<Author, bool> lambda = author => author.Name.StartsWith(c);
            return lambda;
        }

        private static Func<Book, bool> GetTitleLambdaForCharacter(char c)
        {
            Func<Book, bool> lambda = book => book.Title.StartsWith(c);
            return lambda;
        }

        private static Func<T, bool> GetStartsWithLambda<T>(char c, Func<T,string> selector)
        {
            Func<T, bool> lambda = item => {
                var stringFromItem = selector(item);
                return stringFromItem.StartsWith(c);
            };
            return lambda;
        }

        private static Func<char, Func<T, bool>> GetStartsWithLambdaGenerator<T>(Func<T, string> selector)
        {
            Func<char, Func<T, bool>> result = (c) =>
            {
                Func<T, bool> lambda = item =>
                {
                    var stringFromItem = selector(item);
                    return stringFromItem.StartsWith(c);
                };
                return lambda;
            };
            return result;
        }
    }
}
