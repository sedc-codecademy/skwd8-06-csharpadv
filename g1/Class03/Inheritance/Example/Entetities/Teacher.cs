using Example.Entetities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Entetities
{
    public class Teacher : User, ITeacher
    {
        public List<string> Subjects { get; set; } = new List<string>();
        public void PrintSubjects()
        {
            foreach (var subject in Subjects)
            {
                Console.WriteLine(subject);
            }
        }
    }
}
