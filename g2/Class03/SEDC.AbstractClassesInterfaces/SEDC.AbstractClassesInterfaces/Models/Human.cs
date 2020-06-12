using SEDC.AbstractClassesInterfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AbstractClassesInterfaces.Models
{
    public abstract class Human : IHuman
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public long Phone { get; set; }

        public Human(string fullName, int age, long phone)
        {
            this.FullName = fullName;
            this.Age = age;
            this.Phone = phone;
        }

        public abstract string GetInfo();

        public void Greet(string name)
        {
            Console.WriteLine($"Hi there {name}! My name is {FullName}");
        }


        //Virtual method can be overrided further in the inheritance chain
        //public virtual void SayHi()
        //{
        //    Console.WriteLine("Hi");
        //}
    }
}
