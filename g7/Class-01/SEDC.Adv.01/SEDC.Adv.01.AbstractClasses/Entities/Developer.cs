using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._01.AbstractClasses.Entities
{
	public class Developer : Human, IDeveloper
	{
		public List<string> ProgrammingLanguages { get; set; }
		public int YearsExperience { get; set; }
		// If we don't have any constructor here, this Developer class will try to access an empty constructor
		// from it's parent. Since we don't have an empty constructor, only one with parameters, we must
		// create a constructor with those required parameters
		public Developer(string fullName, int age, long phone, List<string> languages, int exp) // This is the Developer constructor
			: base(fullName, age, phone) // This is the Human constructor being called with 3 arguments
		{
			ProgrammingLanguages = languages;
			YearsExperience = exp;
		}
		// WE MUST implement this code class since the interface IDeveloper requires it
		public void Code()
		{
			Console.WriteLine("Tak tak tak...");
			Console.WriteLine("*Opens stack overflow...*");
			Console.WriteLine("Tak tak tak tak tak tak...");
			Console.WriteLine("Error");
			Console.WriteLine("TAK TAK TAK TAK TAK TAK BREAKS KEYBOARD TAK TAK");
		}

		// We override the abstract method from the Human class
		public override string GetInfo()
		{
			// This is a place holder for an implementaton that does not yet exist
			// We remove it and add our own implementaiton in its place
			// Always replaced with actual code ( at the mment or later in the development cycle )
			// throw new NotImplementedException();
			return $"{FullName} ({Age}) - {YearsExperience} years of experience!";
		}
	}
}
