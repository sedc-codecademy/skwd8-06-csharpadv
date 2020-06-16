using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //var studentNames = new StudentNames
            //{
            //    ClassName = "C# Advanced",
            //    Lecturer = "Wekoslav Stefanovski",
            //    Assistant = "Kristina Spasovska",
            //    Names = new List<string>
            //    {
            //        "Jovica Dojcinovski",
            //        "Panche Manaskov",
            //        "Ivan Mitev"
            //    }
            //};

            //Console.WriteLine(studentNames.PrintStudents());

            //var studentGrades = new StudentGrades
            //{
            //    ClassName = "C# Advanced",
            //    Lecturer = "Wekoslav Stefanovski",
            //    Assistant = "Kristina Spasovska",
            //    Grades = new List<int>
            //    {
            //        8,
            //        9,
            //        10
            //    }
            //};

            //Console.WriteLine(studentGrades.PrintStudentGrades());

            var grades = new List<double> { 1.5, 2.5, 3.5 };
            //Printer.PrintDoubles(grades);
            Printer.Print(grades);

            var numGrades = new List<int> { 1, 2, 3, 4 };
            Printer.Print(numGrades);

            var vehicles = new List<Vehicle>
            {
                new Vehicle {Registration ="SK-001-AA"},
                new Vehicle {Registration ="SK-002-AB"},
                new Vehicle {Registration ="SK-003-AC"},
            };

            Printer.Print(vehicles);

            Console.WriteLine("------------------");

            var studentNames = new StudentItems<string>
            {
                ClassName = "C# Advanced",
                Lecturer = "Wekoslav Stefanovski",
                Assistant = "Kristina Spasovska",
                Items = new List<string>
                {
                    "Jovica Dojcinovski",
                    "Panche Manaskov",
                    "Ivan Mitev"
                }
            };

            Console.WriteLine(studentNames.PrintStudentItems());

            Console.WriteLine("------------------");


            var authorManager = new EntityManager<Author>();

            var bookManager = new EntityManager<Book>();

            bookManager.SaveEntity(new Book { ID = 1 });
            bookManager.SaveEntity(new Book { ID = 5 });
            bookManager.SaveEntity(new Book { ID = 17 });

            Printer.Print(bookManager.GetAllEntities());


        }

    }
}
