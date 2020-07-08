using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SEDC.Adv10.FileSystemDatabase.Entities
{
	public class Student : BaseEntity
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public Student(string first, string last, int age)
		{
			FirstName = first;
			LastName = last;
			Age = age;
		}

		public override string Info()
		{
			return $"{Id}) {FirstName} {LastName}, {Age} years old!";
		}
	}
}
