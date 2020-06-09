using Example.Entetities;
using System;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Id = 1,
                Name = "John",
                Password = "123",
                UserName = "John_Doe",
                Grades = new List<int>(){ 5, 5, 5, 5, 5 }
            };
            Teacher teacher1 = new Teacher()
            {
                Id = 2,
                Name = "Ivan",
                Password = "Ivan123",
                UserName = "Ivanco",
                Subjects = { "CSS", "HTML", "JavaScript", "C sharp" }
            };
            student1.Printuser();
            Console.WriteLine("------------------------------------");
            teacher1.Printuser();
            Console.WriteLine("--------------------------------------");
            student1.ShowGrades();
            Console.WriteLine("--------------------------------------");
            teacher1.PrintSubjects();
        }
    }
}
