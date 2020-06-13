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
			
			// Generic methods

		}
	}
}
