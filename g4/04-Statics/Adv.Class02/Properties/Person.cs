
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Properties
{
    public class Person
    {
        public Person() { }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        //public Person(string firstName, int age)
        //{
        //    FirstName = firstName;
        //    Age = age;
        //}

        //public Person(int age, string lastName)
        //{
        //    LastName = lastName;
        //    Age = age;
        //}


        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Age = person.Age;
        }



        private string firstName;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Value cannot be null or empty");
                }
                firstName = value;
            }
        }

        public string LastName;

        public int Age { get; set; }


    }
}
