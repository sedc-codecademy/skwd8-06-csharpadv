using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._01.AbstractClasses.Entities
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
			Console.WriteLine($"{feature} feature is being tested...");
			Console.WriteLine("Testing complete!");
		}
	}
}
