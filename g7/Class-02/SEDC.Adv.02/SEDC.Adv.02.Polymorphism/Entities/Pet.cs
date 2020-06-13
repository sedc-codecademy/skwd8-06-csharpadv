using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._02.Polymorphism.Entities
{
	public abstract class Pet
	{
		public string Name { get; set; }
		public abstract void Eat();
	}
}
