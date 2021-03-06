﻿using System;

namespace Adv09.Nullable
{
	public class Person
	{
		public int Id { get; set; }
		public int? Score { get; set; }
		public bool IsEmployed { get; set; }
		public bool? HasPet { get; set; }
		public string Name { get; set; }
	}
	class Program
	{
		static void Main(string[] args)
		{
			Person prs = new Person();
			Console.WriteLine(prs.Id); // Is 0 by default
			Console.WriteLine(prs.Score); // Is null by default
			// prs.Id = null; // We can't put null in an int
			prs.Score = null; // If it's nullable we can

			Console.WriteLine(prs.IsEmployed); // Is false by default
			Console.WriteLine(prs.HasPet); // Is null by default
			// prs.IsEmployed = null; // We can't put null in a bool
			prs.HasPet = null; // If it's nullable we can

			Console.WriteLine(prs.Name == null); // Is null by default
			prs.Name = "Bob"; // String is nullable by default
			prs.Name = null; // We can add values to nullable types 

			prs = null; // Every object is nullable and can hold null by default

			Console.ReadLine();
		}
	}
}
