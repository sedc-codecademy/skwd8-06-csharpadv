// We bundle our extension methods for Lists in to the same namespace that is required for List type to be used
namespace System.Collections.Generic
{
	public static class ListHelper
	{
		public static void GoThrough<T>(this List<T> items)
		{
			foreach (T item in items)
			{
				Console.WriteLine(item);
			}
		}

		public static void GetInfo<T>(this List<T> items)
		{
			T first = items[0];
			Console.WriteLine($"This list has {items.Count} members and is of type {first.GetType().Name}!");
		}
	}
}
