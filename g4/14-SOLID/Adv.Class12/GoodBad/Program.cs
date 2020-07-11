using System;
using System.Collections.Generic;
using System.Linq;

namespace GoodBad
{
    class Person {
        public string Name { get; set; } = string.Empty;

        public static Person EmptyPerson = new Person { Name = string.Empty };
    }

    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int? nulint = (random.NextDouble() > 0.5) ? (int?)10 : null;

            // Console.WriteLine(nulint.GetValueOrDefault(-1));
            Console.WriteLine(nulint ?? -1);

            List<Person> p = GetPersons();
            
            var firstPerson = p.FirstOrDefault() ?? Person.EmptyPerson;

            //if (firstPerson == null)
            //{
            //    throw new ApplicationException("There are no persons in the GetPersons call");
            //}

            Console.WriteLine(firstPerson.Name);

        }

        private static List<Person> GetPersons()
        {
            //return null;
            return new List<Person>();
        }
    }
}
