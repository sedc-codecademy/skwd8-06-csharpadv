using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._01.AbstractClasses.Entities
{
	// VS helps with generating all the methods that you need from an interface
	// You can always write those methods manually as well. It has the same effect
	public abstract class Human : IHuman
	{
		public string FullName { get; set; }
		public int Age { get; set; }
		public long Phone { get; set; }

		// This constructor is called in the child classes constructors
		public Human(string fullName, int age, long phone)
		{
			FullName = fullName;
			Age = age;
			Phone = phone;
		}
		// This is an abstarct method
		// It does not have an implementation
		// It will force all the child classes that inherit from this class to override it and give implementation
		// GetInfo is different for Developer, Tester and Operations so that is why we use an abstract method
		public abstract string GetInfo();

		// Greet is the same for all humans
		public void Greet(string name)
		{
			Console.WriteLine($"Hey there {name}! My name is {FullName}!");
		}
	}
}
