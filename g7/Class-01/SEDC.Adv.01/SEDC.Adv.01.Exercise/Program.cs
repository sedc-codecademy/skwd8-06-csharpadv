using SEDC.Adv._01.Exercise.Entities;
using System;
using System.Collections.Generic;

namespace SEDC.Adv._01.Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Student bob = new Student()
            {
                Id = 1,
                Name = "Bob",
                Username = "Bob44",
                Password = "bobSuper",
                Grades = new List<int>() { 3, 3, 4, 4, 3, 5 }
            };
            Student jill = new Student()
            {
                Id = 2,
                Name = "Jill",
                Username = "JillJill",
                Password = "jillCool",
                Grades = new List<int>() { 5, 5, 5, 2, 5, 5 }
            };
            Teacher greg = new Teacher()
            {
                Id = 3,
                Name = "Greg",
                Username = "grego",
                Password = "greggreggreg",
                Subjects = new List<string>() { "C#", "MVC", "WebAPI" }
            };
            Teacher anne = new Teacher()
            {
                Id = 4,
                Name = "Anne",
                Username = "Annnne",
                Password = "Sparkymydog",
                Subjects = new List<string>() { "HTML", "CSS" }
            };
            bob.PrintUser();
            jill.PrintUser();
            greg.PrintUser();
            anne.PrintUser();
            Console.ReadLine();
        }
    }
}
