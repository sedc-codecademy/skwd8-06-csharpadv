using System;

namespace Adv.Class03.Structs
{
	// For most of our entities that might:
	// Use inheritance to create a business logic tree ( Inheritance )
	// Use overriding to use a method in different scenarios ( polymorphism )
	// That it has more responsibilities than just storing data
	// Have members that are a refference type ( object )
	// We would always use a Class
	public class User
	{
		public string Username { get; set; }
		public int Age { get; set; }
		public Address Address { get; set; }
		// Since we created this constructor and we don't have a default one, we can't create User without paramteres
		public User(string username, int age, Address address)
		{
			Username = username;
			Age = age;
			Address = address;
		}
		public string GetInfo()
		{
			return $"{Username} ({Age})";
		}
	}
	// A struct can be used:
	// When the only reason we need the entity is to store some data
	// When we want to pass the data by value instead of by reference
	// When we know that we will never use the entity as a business logic tree ( Inheritance )
	// When all members are a value type ( int, string, bool etc. )
	public struct Address
	{
		public string Street { get; set; }
		public int Number { get; set; }
		// We can create a constructor in a struct
		// We can't create an empty ( default ) constructor, we must provide all the members
		// Unlike the classes, even tho we don't have a default constructor Address struct can still be created without parameters
		public Address(string street, int number)
		{
			Street = street;
			Number = number;
		}
		public string GetFullAddress()
		{
			return $"{Street} No. {Number}";
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Address address = new Address("Bob Street", 11);
			// Address address = new Address() { Street = "Bob Street", Number = 11 }; // This also works
			User bob = new User("BobBest", 21, address);
			// User bob = new User() { Username = "BobBest", Age = 21, Address = address }; // This does not work
			Console.WriteLine(bob.GetInfo());
			Console.WriteLine(address.GetFullAddress());
			Address newAddress = address;
			newAddress.Number = 50;
			newAddress.Street = "New Street";
			User bobTwin = bob;
			bobTwin.Username = "BobSuper";
			bobTwin.Age = 45;
			Console.WriteLine("----------after changes-----------");
			Console.WriteLine(bob.GetInfo());
			Console.WriteLine(address.GetFullAddress());
			Console.ReadLine();

		}
	}
}
