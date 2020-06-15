using System;

namespace SEDC.Adv.TryBeingFit.App
{
    // Creating the structure:
    // 
    // Refferences
    // Services need a refference to domain
    // App need both domain and services
    //
    // When we are connecting references there can't be a circle from the refrences
    // This means that as long as the references connect to each other but don't for ma loop we are fine
    // When references point one to each other then we have a problem of circular reference

    // Domain structure
    // Core -> A folder with all business logic entities
    // -- Entities      -> All the classes
    // -- Enumerations  -> All the enums
    // -- Interfaces    -> All the interfaces

	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
