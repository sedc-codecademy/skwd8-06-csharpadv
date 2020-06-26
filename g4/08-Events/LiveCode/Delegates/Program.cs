using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace Delegates
{
    public delegate int IntOperation(int x, int y);

    public delegate IEnumerable<int> TakeTwoListsAndOperate(IEnumerable<int> first, IEnumerable<int> second);

    interface IPerson
    {
        string FirstName { get; }
        string LastName { get; }
        int Length(int first, int second);
    }

    class Person: IPerson
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public int Length(int first, int second)
        {
            return FirstName.Length + LastName.Length + first * second;
        }
    }

    class Program
    {
        static void PrintFullName(IPerson person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }

        static void ExecOperation(IntOperation operation)
        {
            Console.WriteLine(operation(10, 2));
        }

        static void Main(string[] args)
        {
            IPerson p = new Person("Wekoslav", "Stefanovski");
            PrintFullName(p);

            Func<int, int> square = x => x * x;
            Func<int, int> cube = x => x * x * x;

            IntOperation add = (x, y) => x + y;
            IntOperation sub = (x, y) => x - y;
            IntOperation mul = (x, y) => x * y;
            IntOperation div = (x, y) => x / y;

            TakeTwoListsAndOperate addTwoLists = (first, second) => from f in first from s in second select f + s;

            ExecOperation(add);

            ExecOperation(Substraction);

            ExecOperation(p.Length);

            var p2 = new Person("Ivan", "Acev");
            ExecOperation(p2.Length);
        }

        static int Substraction(int first, int second)
        {
            return first - second;
        }


    }
}
