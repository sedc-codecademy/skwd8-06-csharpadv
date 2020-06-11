using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class03.Polymorphism.Entities
{
	public class Dog : Pet
	{
		public bool IsGoodBoi { get; set; }
		public override void Eat()
		{
			Console.WriteLine("Nom nom noming on dog food!");
		}
	}
}
