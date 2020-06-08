using SEDC.Adv.Class01.AbstractInterface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class01.AbstractInterface.Entities
{
    public abstract class Human : IHuman
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }

        public Human(string fullName, int age, long phone)
        {
            FullName = fullName;
            Age = age;
            Phone = phone;
        }

        public void Greet(string name)
        {
            Console.WriteLine($"Hey there {name}! My name is {FullName}");
        }

        public abstract string GetInfo();
    }
}
