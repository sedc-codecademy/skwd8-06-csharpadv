using SEDC.Adv._02.Polymorphism.Entities;
using System;

namespace SEDC.Adv._02.Polymorphism
{
	class Program
	{
		// Static polymorphism (Method overloading)
		// Methods that have the same name should also follow these rules, to count as different methods:
		// 1. The types of the paramters must be different
		// 2. The order of the paramter types must be different
		// 3. The number of paramteres must be different
		// If at least one of these is met, the method will be polymorphic and not the same as the other methods that are named the same
		
		// This will not work since both of them are string - string string
		// If we swap them they will still be string string 
		//public static void Hello(string name, string friend)
		//{
		//	// ... something
		//}
		//public static void Hello(string friend, string name)
		//{
		//	// ... something
		//}

		// ALL OF THESE METHODS EXIST IN THE SAME CLASS 
		// THAT IS WHY THEY CAN'T HAVE THE SAME SIGNATURES

		// This works
		// We have Dog string parateres here
		// But on the other we have string Dog
		public static void PetStatus(Dog pet, string ownerName)
		{
			Console.WriteLine($"Hey there {ownerName}!");
			if (pet.IsGoodBoi) Console.WriteLine("This dog is a good boi!");
			else Console.WriteLine("This dog is not really a good boi!");
		}
		public static void PetStatus(string ownerName, Dog pet)
		{
			Console.WriteLine($"Hey there {ownerName}!");
			if (pet.IsGoodBoi) Console.WriteLine("This dog is still a good boi!");
			else Console.WriteLine("This dog is still not really a good boi!");
		}

		// This method is okay and different from the other
		// The first ->   Dog, string
		// This one is -> Cat, string
		public static void PetStatus(Cat pet, string ownerName)
		{
			Console.WriteLine($"Hey there {ownerName}!");
			if (pet.IsLazy) Console.WriteLine("This cat is a lazy!");
			else Console.WriteLine("This cat is not really a lazy!");
		}
		// This is also okay since it has different number of paramters
		// The previous one has -> Cat, string
		// This one has         -> Cat
		public static void PetStatus(Cat pet)
		{
			Console.WriteLine($"This cat has no owner!");
			if (pet.IsLazy) Console.WriteLine("This cat is a lazy!");
			else Console.WriteLine("This cat is not really a lazy!");
		}
		static void Main(string[] args)
		{
			Dog sparky = new Dog() { Name = "Sparky", IsGoodBoi = true };
			Cat meow = new Cat() { Name = "Meow", IsLazy = false };
			// All the ethods can be called with the same name
			// These methods will execute 4 different methods even though it looks like it is the same
			PetStatus(sparky, "Bob");
			PetStatus("Bob", sparky);
			PetStatus(meow, "Jill");
			PetStatus(meow);
			Console.ReadLine();

			// Runtime polymorphism - With inheritance ( Dynamic )
			Console.WriteLine("--------------------------------");
			// It looks like we are calling the SAME method
			// But they are completly different since they come from a different instance
			sparky.Eat();
			meow.Eat();
			Console.ReadLine();

			// THESE ARE NOT RULES
			// THESE ARE INTERPRETATIONS OF THE BUSINESS LOGIC FOR THIS APPLICATION

			// PetStatus() - A method that is not connected to any particular Pet
			// It is a stand alone method ( Independent )
			// It's job is to write some info for a pet and it's owner
			// From PetStatus we can't access pet properties without passing a Pet like Dog or Cat as parameter

			// Eat() - A method that is conneted directly on to some particular Pet
			// This logic makes sense only for that pet ( the object )
			// A dog sparky can bark or eat and those actions are different for each individual dog

			// PetStatus can be called for different pets and same owner or same owners and different pets
			// It is not connected to any individual entity in our logic
			// We can connect it if we want to an Owner or a Pet but in this implementation we decide not to
			
		}
	}
}
