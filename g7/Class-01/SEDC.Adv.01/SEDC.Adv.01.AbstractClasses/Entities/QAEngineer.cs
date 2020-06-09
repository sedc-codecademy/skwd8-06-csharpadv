using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._01.AbstractClasses.Entities
{
	public class QAEngineer : Human, IDeveloper, ITester
	{
		public List<string> TestFrameworks { get; set; }

		public QAEngineer(string fullName, int age, long phone, List<string> frameworks)
			: base(fullName, age, phone)
		{
			TestFrameworks = frameworks;
		}
		public void Code()
		{
			Console.WriteLine("Tak tak tak...");
			Console.WriteLine("*Checks StackExchange SQA*");
			Console.WriteLine("Tak tak tak tak tak...");
		}

		public override string GetInfo()
		{
			return $"{FullName} ({Age}) - Knows {TestFrameworks.Count} test frameworks!";
		}

		public void TestFeature(string feature)
		{
			Console.WriteLine($"Run unit tests for {feature} feature...");
			Console.WriteLine($"Run automated tests for {feature} feature...");
			Console.WriteLine("Tests are finished...");
		}
	}
}
