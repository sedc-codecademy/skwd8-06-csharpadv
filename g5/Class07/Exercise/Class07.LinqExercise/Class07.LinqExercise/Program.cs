﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Class07.LinqExercise
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Occupation { get; set; }
        public List<Dog> Dogs { get; set; }

        public Person(string firstName, string lastName, int age, Job occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
            Dogs = new List<Dog>();
        }
    }

    public class Dog
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Race Race { get; set; }

        public Dog(string name, string color, int age, Race race)
        {
            Name = name;
            Color = color;
            Age = age;
            Race = race;
        }
    }

    public enum Race
    {
        Boxer,
        Bulldog,
        Collie,
        Dalmatian,
        Doberman,
        Mutt,
        Mudi,
        Pointer,
        Pug,
        Plott
    }

    public enum Job
    {
        Archivist,
        Waiter,
        Choreographer,
        Developer,
        Dentist,
        Sculptor,
        Interpreter,
        Barber
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Charlie", "Black", 3, Race.Collie), // 0
                new Dog("Buddy", "Brown", 1, Race.Doberman),
                new Dog("Max", "Olive", 1, Race.Plott),
                new Dog("Archie", "Black", 2, Race.Mutt),
                new Dog("Oscar", "White", 1, Race.Mudi),
                new Dog("Toby", "Maroon", 3, Race.Bulldog), // 5
                new Dog("Ollie", "Silver", 4, Race.Dalmatian),
                new Dog("Bailey", "White", 4, Race.Pointer),
                new Dog("Frankie", "Gray", 2, Race.Pug),
                new Dog("Jack", "Black", 5, Race.Dalmatian),
                new Dog("Chanel", "Black", 1, Race.Pug), // 10
                new Dog("Henry", "White", 7, Race.Plott),
                new Dog("Bo", "Maroon", 1, Race.Boxer),
                new Dog("Scout", "Olive", 2, Race.Boxer),
                new Dog("Ellie", "Brown", 6, Race.Doberman),
                new Dog("Hank", "Silver", 2, Race.Collie), // 15
                new Dog("Shadow", "Silver", 3, Race.Mudi),
                new Dog("Diesel", "Brown", 4, Race.Bulldog),
                new Dog("Abby", "Black", 1, Race.Dalmatian),
                new Dog("Trixie", "White", 8, Race.Pointer), // 19
            };

            List<Person> people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Rick", "Chapman", 35, Job.Dentist),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Developer),
                new Person("Richie", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Rocky", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter)
                { Dogs = new List<Dog>() {dogs[16], dogs[18] } },
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist)
                { Dogs = new List<Dog>(){dogs[6], dogs[0] } },
                new Person("Erin", "Rocha", 37, Job.Developer)
                { Dogs = new List<Dog>() {dogs[2], dogs[3], dogs[19] } },
                new Person("Freddy", "Gordon", 26, Job.Sculptor)
                { Dogs = new List<Dog>() {dogs[4], dogs[5], dogs[10], dogs[12], dogs[13] } },
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 28, Job.Dentist)
                { Dogs = new List<Dog>() {dogs[9], dogs[14], dogs[15] } }
            };

            // Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
            List<string> s1 = people
              .OrderByDescending(x => x.Age)
              .Select(x => x.FirstName)
              .Where(x => x.StartsWith("R")).ToList();

            // Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            List<string> s2 = dogs
               .Where(x => x.Color == "Brown" && x.Age > 3)
               .OrderBy(x => x.Age)
               .Select(x => $"{x.Name} {x.Age}").ToList();

            // Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            List<Person> s3 = people
            .Where(x => x.Dogs.Count > 2)
            .OrderByDescending(x => x.FirstName)
            .ToList();

            // Find and print all Freddy`s dogs names older than 1 year
            List<string> s4 = people
             .Single(x => x.FirstName == "Freddy").Dogs
             .Where(x => x.Age > 1)
             .Select(x => x.Name).ToList();

            // Find and print Nathen`s first dog
            Dog s5 = people
            .Single(x => x.FirstName == "Nathen").Dogs
            .First();

            // Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER

         List<string> s6 = people.Where(x => x.FirstName == "Cristofer" ||
            x.FirstName == "Freddy" || x.FirstName == "Erin" || x.FirstName == "Amelia")
                .SelectMany(x => x.Dogs)
                .Where(x => x.Color == "White")
                .OrderBy(x => x.Name).Select(x => x.Name).ToList();



        }
    }
}
