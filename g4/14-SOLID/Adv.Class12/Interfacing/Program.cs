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

            Func<Person, Person, int> byAgeComparison = (Person x, Person y) => {
                Console.WriteLine("Called comparison");
                if (x == null) return -1;
                if (y == null) return 1;
                return x.Age.CompareTo(y.Age);
            };

            static int ByAgeComparisonLocal(Person x, Person y)
            {
                Console.WriteLine("Called local comparison");
                if (x == null) return -1;
                if (y == null) return 1;
                return x.Age.CompareTo(y.Age);
            }

            // persons.Sort(new Comparison<Person>(byAgeComparison));
            // persons.Sort(new Comparison<Person>(ByAgeComparison));
            persons.Sort(ByAgeComparisonLocal); 
            // equivalent to persons.Sort(new Comparison<Person>(ByAgeComparisonLocal));
            
            // persons.Where(p => p != null).ToList().Sort((f, s) => f.Age.CompareTo(s.Age));

            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }

        static int ByAgeComparison(Person x, Person y) {
            Console.WriteLine("Called ByAgeComparison method");
            if (x == null) return -1;
            if (y == null) return 1;
            return x.Age.CompareTo(y.Age);
        }
    }
}
