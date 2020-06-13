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
		static void Main(string[] args)
		{
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
		}
	}
}
