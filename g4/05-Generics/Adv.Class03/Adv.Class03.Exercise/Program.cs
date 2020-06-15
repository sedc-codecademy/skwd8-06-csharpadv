using Adv.Class03.Exercise.Entities;
using System;

namespace Adv.Class03.Exercise
{
	class Program
	{
		static void GenericMethod<T>(T item) where T : Pet
		{

		}

		static PetStore<Dog> dogStore = new PetStore<Dog>();
		static PetStore<Cat> catStore = new PetStore<Cat>();
		static PetStore<Fish> fishStore = new PetStore<Fish>();
		static void Main(string[] args)
		{
			dogStore.Pets.Add(new Dog("Sparky", 3, true, "Carrot"));
			dogStore.Pets.Add(new Dog("Zoe", 1, false, "Apple"));
			catStore.Pets.Add(new Cat("Meow", 2, false, 9));
			catStore.Pets.Add(new Cat("Kitty", 4, true, 7));
			fishStore.Pets.Add(new Fish("Blob", 0, "Yellow", 5));
			fishStore.Pets.Add(new Fish("Bubbles", 1, "Blue", 12));

			dogStore.BuyPet("Sparky");
			catStore.BuyPet("Meow");

			dogStore.PrintPets();
			catStore.PrintPets();
			fishStore.PrintPets();

			Console.ReadLine();
		}
	}
}
