using SEDC.Adv.Class01.AbstractInterface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class01.AbstractInterface.Entities
{
    public class Developer : Human, IDeveloper, IHuman
    {
        public List<string> ProgrammingLanguages { get; set; } = new List<string>();
        public int YearsExperience { get; set; }

        public Developer(string fullName, int age, long phone, List<string> progLang, int yearEx)
            : base(fullName, age, phone)
        {
            ProgrammingLanguages = progLang;
            YearsExperience = yearEx;
        }
        
        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - {YearsExperience} years of experience!";
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("*Opens Stack Overflow...");
            Console.WriteLine("tak tak tak tak tak tak...");
        }
    }
}
