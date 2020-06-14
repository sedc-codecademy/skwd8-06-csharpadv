using SEDC.Adv._03Generics.Entities;
using SEDC.Adv._03Generics.Helpers;
using System;
using System.Collections.Generic;

namespace SEDC.Adv._03Generics
{
	// Usecase:
	// We need an app that will use Lists of stuff a lot
	// We can create a helper class that can help us go throug lists easier instead of us typing foreach or for every time
	class Program
	{
		// Here we create two instances of the generic class
		// One accepts Product as T so it will change every T in the intance to Product
		// The other accepts Order as T so it will change every T in the intance to Order
		public static GenericDb<Product> ProductDb = new GenericDb<Product>();
		public static GenericDb<Order> OrderDb = new GenericDb<Order>();
		static void Main(string[] args)
		{
			#region Generics with primitive types
			List<string> strings = new List<string>() { "str1", "str2", "str3" };
			List<int> ints = new List<int>() { 5, 22, -18 };
			List<bool> bools = new List<bool> { true, false, true };

			// Not generic methods
			Console.WriteLine("NOT GENERIC --------------");
			NotGenericListHelper.GoThrougStrings(strings);
			NotGenericListHelper.GetInfoForStrings(strings);
			NotGenericListHelper.GoThrougInts(ints);
			NotGenericListHelper.GetInfoForInts(ints);
			NotGenericListHelper.GoThrougBools(bools);
			NotGenericListHelper.GetInfoForBools(bools);

			// THIS IS AN EXAMPLE FOR GENERIC METHODS
			Console.WriteLine("GENERIC METHODS --------------");
			// GenericListHelper.GoThrough<string>(strings); // OG type of writing generic methods
			// Even though the above example is a correct implementation, it has a simple version. The one bellow
			GenericListHelper.GoThrough(strings);
			GenericListHelper.GetInfo(strings);
			GenericListHelper.GoThrough(ints);
			GenericListHelper.GetInfo(ints);
			GenericListHelper.GoThrough(bools);
			GenericListHelper.GetInfo(bools);
			List<char> chars = new List<char>() { 'c', 'b', '0' };
			GenericListHelper.GoThrough(chars);
			GenericListHelper.GetInfo(chars);

			// Generic class
			GenericListHelperClass<string> genericHelper1 = new GenericListHelperClass<string>();
			GenericListHelperClass<int> genericHelper2 = new GenericListHelperClass<int>();
			GenericListHelperClass<bool> genericHelper3 = new GenericListHelperClass<bool>();
			Console.WriteLine("GENERIC CLASS --------------");
			genericHelper1.GoThrough(strings);
			genericHelper1.GetInfo(strings);
			genericHelper2.GoThrough(ints);
			genericHelper2.GetInfo(ints);
			genericHelper3.GoThrough(bools);
			genericHelper3.GetInfo(bools);

			Console.ReadLine();
			#endregion
			#region Generics with complex types
			// When we call the insert method on OrderDb the items will be stored in a list of orders
			// When we call the insert method on ProductDb the items will be stored in a list of products
			Console.Clear();
			OrderDb.Insert(new Order() { Id = 1, Address = "Bob street 29", Receiver = "Bob" });
			OrderDb.Insert(new Order() { Id = 2, Address = "Jill street 31", Receiver = "Jill" });
			OrderDb.Insert(new Order() { Id = 3, Address = "Greg street 11", Receiver = "Greg" });
			ProductDb.Insert(new Product() { Id = 1, Description = "For gaming", Title = "Mouse" });
			ProductDb.Insert(new Product() { Id = 2, Description = "Mechanical", Title = "Keyboard" });
			ProductDb.Insert(new Product() { Id = 3, Description = "64GB", Title = "USB" });
			Console.WriteLine("-----------------------------");
			Console.WriteLine("Orders:");
			OrderDb.PrintAll();
			Console.WriteLine("Products:");
			ProductDb.PrintAll();
			Console.WriteLine("------ Get by id 1 from Orders -----");
			Console.WriteLine(OrderDb.GetById(1).GetInfo());
			Console.WriteLine("------ Get by id 1 from Products -----");
			Console.WriteLine(ProductDb.GetById(1).GetInfo());
			Console.WriteLine("------ Removing id 1 from Orders -----");
			OrderDb.DeleteById(1);
			Console.WriteLine("------ Removing id 1 from Products -----");
			ProductDb.DeleteById(1);
			Console.WriteLine("-----------------------------");
			Console.WriteLine("Orders:");
			OrderDb.PrintAll();
			Console.WriteLine("Products:");
			ProductDb.PrintAll();
			Console.ReadLine();
			#endregion
		}
	}
}
