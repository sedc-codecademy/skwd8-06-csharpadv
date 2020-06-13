using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._03Generics.Helpers
{
	public static class NotGenericListHelper
	{
		public static void GoThrougStrings(List<string> strings)
		{
			foreach (string str in strings)
			{
				Console.WriteLine(str);
			}
		}
		public static void GoThrougInts(List<int> ints)
		{
			foreach (int num in ints)
			{
				Console.WriteLine(num);
			}
		}
		public static void GoThrougBools(List<bool> bools)
		{
			foreach (bool bl in bools)
			{
				Console.WriteLine(bl);
			}
		}
		public static void GetInfoForStrings(List<string> strings)
		{
			string first = strings[0];
			// GetType() -> Gets the type of a variable and returns a string with the namespace as well as the type
			// .Name only returns the type without the other strings ( namespace )
			Console.WriteLine($"This list has {strings.Count} members and the are of type {first.GetType().Name}");
		}
		public static void GetInfoForInts(List<int> ints)
		{
			int first = ints[0];
			Console.WriteLine($"This list has {ints.Count} members and the are of type {first.GetType().Name}");
		}
		public static void GetInfoForBools(List<bool> bools)
		{
			bool first = bools[0];
			Console.WriteLine($"This list has {bools.Count} members and the are of type {first.GetType().Name}");
		}
	}
}
