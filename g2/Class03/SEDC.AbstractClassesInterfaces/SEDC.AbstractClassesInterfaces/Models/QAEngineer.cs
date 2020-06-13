using SEDC.AbstractClassesInterfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.AbstractClassesInterfaces.Models
{
    public class QAEngineer : Human, ITester
    {
        public List<string> TestingFrameworks { get; set; }
        public bool IsAutomated { get; set; }

        public QAEngineer(string fullName, int age, long phone, List<string> frameworks)
            :base(fullName, age, phone)
        {
            this.TestingFrameworks = frameworks;
            this.IsAutomated = true;
        }

        public void TestFeature(string feature)
        {
            Console.WriteLine($"I am testing {feature} feature!");
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - Knows { (TestingFrameworks.Count != 0 ? TestingFrameworks.Count.ToString() : "no frameworks")} testing frameworks!";
        }
    }
}
