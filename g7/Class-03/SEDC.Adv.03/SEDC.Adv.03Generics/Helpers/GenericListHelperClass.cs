using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._03Generics.Helpers
{
	// This class is generic
	// Bad thing -> It does not work well with static
	// Good thing -> We can have different instances of the same class that have different type implementation
	// Very usefull when building services -> Product service -> Special class with these methods but for products
	// Order service -> The same class but different instance with different types
	// All methods and properties can USE T in the class 
	public class GenericListHelperClass<T>
	{
		public void GoThrough(List<T> items)
		{
			foreach (T item in items)
			{
				Console.WriteLine(item);
			}
		}

		public void GetInfo(List<T> items)
		{
			T first = items[0];
			Console.WriteLine($"This list has {items.Count} members and the are of type {first.GetType().Name}");
		}
	}
}
