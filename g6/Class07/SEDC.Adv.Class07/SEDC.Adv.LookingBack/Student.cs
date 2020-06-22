using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.LookingBack
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }

        public Student()
        {

        }

        public Student(int age)
        {

        }

        public Student(string name)
        {

        }

        public override string ToString()
        {
            string result = $"{FirstName} {LastName} - {Age} years old.";
            result += IsPartTime ? " A part time student!" : "";
            return result;
        }
    }
}
