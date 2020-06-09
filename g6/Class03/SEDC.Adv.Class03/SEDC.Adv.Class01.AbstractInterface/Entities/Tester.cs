using SEDC.Adv.Class01.AbstractInterface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class01.AbstractInterface.Entities
{
    public class Tester : Human, ITester
    {
        public int BugsFound { get; set; }
        public Tester(string fullName, int age, long phone, int bugs)
            : base(fullName, age, phone)
        {
            BugsFound = bugs;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - found {BugsFound} bugs to date!";
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine($"{feature} is being tested...");
            Console.WriteLine("Testing complete...");
        }
    }
}
