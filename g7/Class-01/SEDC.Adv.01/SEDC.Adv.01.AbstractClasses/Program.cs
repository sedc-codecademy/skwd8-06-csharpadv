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

			Console.WriteLine(dev.GetInfo());
			Console.WriteLine(tester.GetInfo());
			Console.WriteLine(ops.GetInfo());

			Console.ReadLine();
		}
	}
}
