using Example.Entetities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Entetities
{
    public class Student : User, IStudent
    {
        public List<int> Grades { get; set; }

        public void ShowGrades()
        {
            foreach (var grade in Grades)
            {
                Console.WriteLine(grade);
            }
        }
    }
}
