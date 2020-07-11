using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfacing
{
    class Program
    {
        static void Main(string[] args)
        {
            var weko = new Person
            {
                FirstName = "Wekoslav",
                LastName = "Stefanovski",
                Age = 42
            };

            var dimitar = new Person
            {
                FirstName = "Dimitar",
                LastName = "Risteski",
                Age = 32
            };

            List<Person> persons = new List<Person> { weko, dimitar, null };

            // sorts by default, by age
            persons.Sort();
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

            if (weko.CompareTo(dimitar) > 0)
            {
                Console.WriteLine("Weko");
            }
            else
            {
                Console.WriteLine("Dimitar");
            }

            var weko2 = new Person
            {
                FirstName = "Wekoslav",
                LastName = "Stefanovski",
                Age = 43
            };

            Console.WriteLine(weko.Equals(weko2));

            persons.Add(weko2);

            persons.Sort(new PersonByNameComparer());

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }

            // persons.Sort()
        }
    }
}
