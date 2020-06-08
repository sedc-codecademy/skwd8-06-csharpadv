using SEDC.Adv._01.AbstractClasses.Entities;
using System;
using System.Collections.Generic;

namespace SEDC.Adv._01.AbstractClasses
{
	class Program
	{
		static void Main(string[] args)
		{
			// WE CAN'T CREATE A NEW INSTANCE OF AN ABSTRACT CLASS OR INTERFACE
			// Human bob1 = new Human("Bob", 28, 38970707070);
			// IHuman bob2 = new IHuman();

			Developer dev = new Developer("Bob Bobsky", 44, 38970070070,
				new List<string>() { "JavaScript", "C#", "HTML", "CSS" }, 6);
			Tester tester = new Tester("Jill Wayne", 32, 38971071071, 560);
			Operations ops = new Operations("Greg Gregsky", 28, 38975075075,
				new List<string>() { "Optimus", "ProtoBeat", "PickPro" });
			DevOps devOps = new DevOps("Anne Brown", 24, 38977070070, true, false);
			QAEngineer qa = new QAEngineer("Mia Wong", 34, 38972072072,
				new List<string>() { "Selenium" });
			Console.WriteLine("WELCOME TO THE COMPANY APP");
			Console.WriteLine("--------------------------");
			Console.WriteLine("Developer:");
			Console.WriteLine(dev.GetInfo());
			dev.Greet("Students");
			dev.Code();
			Console.WriteLine("--------------------------");
			Console.WriteLine("Tester:");
			Console.WriteLine(tester.GetInfo());
			tester.Greet("Students");
			tester.TestFeature("Log in");
			Console.WriteLine("--------------------------");
			Console.WriteLine("IT Operations:");
			Console.WriteLine(ops.GetInfo());
			ops.Greet("Students");
			Console.WriteLine($"Infrastructure OK: {ops.CheckInfrastructure(200)}");
			Console.WriteLine("--------------------------");
			Console.WriteLine("QA Engineer:");
			Console.WriteLine(qa.GetInfo());
			qa.Greet("Students");
			qa.TestFeature("Log out");
			qa.Code();
			Console.WriteLine("--------------------------");
			Console.WriteLine("Dev Ops:");
			Console.WriteLine(devOps.GetInfo());
			devOps.Greet("Students");
			Console.WriteLine($"Infrastructure OK: {devOps.CheckInfrastructure(404)}");
			devOps.Code();




			Console.ReadLine();
		}
	}
}
