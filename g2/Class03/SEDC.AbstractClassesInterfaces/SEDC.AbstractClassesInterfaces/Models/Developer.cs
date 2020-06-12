using SEDC.AbstractClassesInterfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AbstractClassesInterfaces.Models
{
    public class Developer : Human, IDeveloper
    {
        public List<string> ProgrammingLanguages { get; set; }
        public int YearsOfExperience { get; set; }


        public Developer(string fullName, int age, long phone, List<string> languages, int experience)
            :base(fullName, age, phone)
        {
            this.ProgrammingLanguages = languages;
            this.YearsOfExperience = experience;
        }

        public void Code()
        {
            Console.WriteLine("Tak, tak, tak..... I am coding!");
            Console.WriteLine("Open StackOverflow..... I am stuck!");
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {YearsOfExperience} years of experience!";
        }


        //Override of the SayHi() virtual method from Human class
        //public override void SayHi()
        //{
        //    Console.WriteLine("Hi I am a developer!");
        //}

    }
}
