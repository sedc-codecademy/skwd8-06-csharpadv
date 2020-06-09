using SEDC.Adv.Class01.AbstractInterface.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.Class01.AbstractInterface.Entities
{
    public class QAEngineer : Human, ITester, IDeveloper
    {
        public List<string> TestingFrameworks { get; set; } = new List<string>();
        public QAEngineer(string fullName, int age, long phone, List<string> targetFr)
            : base(fullName, age, phone)
        {
            TestingFrameworks = targetFr;
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - Knows {TestingFrameworks.Count} testing frameworks";
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("*Opens Stack Overflow Testing...");
            Console.WriteLine("tak tak tak tak tak tak...");
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine("Run Unit Tests...");
            Console.WriteLine("Run Automated Tests...");
            Console.WriteLine($"Tests for the {feature} feature are done!");
        }
    }
}
