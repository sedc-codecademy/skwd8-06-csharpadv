﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class13.FileSystemDatabase.Entities
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Student(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string Info()
        {
            return $"{FirstName} {LastName}, {Age} years old";
        }
    }
}
