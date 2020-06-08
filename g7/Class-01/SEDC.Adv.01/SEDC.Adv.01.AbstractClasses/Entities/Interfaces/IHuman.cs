using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv._01.AbstractClasses.Entities.Interfaces
{
	// Intefaces look very much like a class but with the keyword inteface
	// A naming convention for writing Intreface names is to put I before the name of the interface
	public interface IHuman
	{
		// These are the rules of this interface
		// Anyone that inherits from this interface MUST IMPLEMENT THESE METHODS AS WRITTEN HERE
		// You can't write code in an interface ( Implementation code )
		string GetInfo();
		void Greet(string name);
		// This code will not work since it is an implementation inside an Interface
		//{
		//	Console.WriteLine("Hey");
		//}
	}
}
