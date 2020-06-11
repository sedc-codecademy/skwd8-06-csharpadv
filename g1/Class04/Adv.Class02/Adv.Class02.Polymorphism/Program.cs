using Adv.Class03.Polymorphism.Entities;
using System;

namespace Adv.Class03.Polymorphism
{
	class Program
	{
		#region Static Polymorphism Methods
		// Static polymorphism ( Method overloading )
		// Both methods have the same name
		// Their signature is different
		public static void PetStatus(Dog pet, string ownerName)
		{
			Console.WriteLine($"Hey there {ownerName}");
			if (pet.IsGoodBoi) Console.WriteLine("This dog is a good boi :)");
			else Console.WriteLine("This dog is not really a good boi :(");
		}
		// Signature is different when the order of the properties do not match
		public static void PetStatus(string ownerName, Dog pet)
		{
			Console.WriteLine($"Hey there {ownerName}. Happy to see you again!");
			if (pet.IsGoodBoi) Console.WriteLine("This dog is still a good boi :)");
			else Console.WriteLine("This dog is still not really a good boi :(");
		}
		// Sugnature is different if the property types do not match
		public static void PetStatus(Cat pet, string ownerName)
		{
			Console.WriteLine($"Hey there {ownerName}");
			if (pet.IsLazy) Console.WriteLine("This cat is really lazy :(");
			else Console.WriteLine("This cat is cool and not lazy at all :)");
		}
		// Sugnature is different if the number of properties do not match
		public static void PetStatus(Cat pet)
		{
			Console.WriteLine($"Hey, a cat with no owner.");
			if (pet.IsLazy) Console.WriteLine("This cat is really lazy :(");
			else Console.WriteLine("This cat is cool and not lazy at all :)");
		}
		#endregion

		static void Main(string[] args)
		{
			#region Dynamic Polymorphism Example
			// Dynamic poloymorphism ( Class method overriding )
			Dog sparky = new Dog() { Name = "Sparky", IsGoodBoi = true };
			Cat meow = new Cat() { Name = "Meow", IsLazy = false };

			// Both call the same method Eat(), but the implementation is different since it is implemented in two different classes
			sparky.Eat();
			meow.Eat();
			Console.ReadLine();
			#endregion
			#region Static Polymorphism Example
			// Static Polymorphism 
			// All methods have the same name but the signature and the impelemtation is different
			PetStatus(sparky, "Bob");
			PetStatus("Bob", sparky);
			PetStatus(meow, "Jill");
			PetStatus(meow);
			Console.ReadLine();
			#endregion
		}
	}
}
