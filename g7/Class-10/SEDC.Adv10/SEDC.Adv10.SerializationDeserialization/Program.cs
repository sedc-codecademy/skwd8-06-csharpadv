using Newtonsoft.Json;
using SEDC.Adv10.SerializationDeserialization.Entities;
using System;

namespace SEDC.Adv10.SerializationDeserialization
{
	class Program
	{
		static void Main(string[] args)
		{
			#region Our own serializer
			Student bob = new Student()
			{
				FirstName = "Bob",
				LastName = "Bobsky",
				Age = 40,
				IsPartTime = false
			};
			Console.WriteLine("Serializing Bob:");
			string bobSerialized = OurJsonSerializer.SerializeStudent(bob);
			Console.WriteLine("Serialization complete!");
			Console.WriteLine(bobSerialized);
			Console.ReadLine();
			Console.WriteLine("Deserializing Bob:");
			Student bobDeserialized = OurJsonSerializer.DeserializeStudent(bobSerialized);
			Console.WriteLine("Deserialization complete!");
			Console.WriteLine(bobDeserialized.FirstName);
			Console.ReadLine();
			#endregion
			#region Newtonsoft.JSON
			// How to install:
			// 1. Right click on the project -> Manage NuGet Packages
			// 2. Click on the Browse tab
			// 3. Find the package that you want to install ( In our case Newtonsoft.JSON )
			// 4. Click the Install button on the right
			// 5. Confirm by clicking Ok
			// 6. ENJOY your library

			// Serialize with Newtonsoft.JSON
			// Newtonsoft.JSON works by name matching
			// If the names do not match it will throw an error
			// You can configure the names in the class it self if you want to custom map some names to others
			// For this configuration check out the Newtonsoft.JSON documentation which is added as a link on the github repo on the README
			string bobSerializedWithNewtonsoft = JsonConvert.SerializeObject(bob);
			Console.WriteLine("Bob is serialized with Newtonsoft.JSON");
			Console.WriteLine(bobSerializedWithNewtonsoft);
			Console.ReadLine();
			Student bobDeserializedWithNewtonsoftJson = JsonConvert.DeserializeObject<Student>(bobSerializedWithNewtonsoft);
			Console.WriteLine("Bob is deserialized with Newtonsoft.JSON");
			Console.WriteLine(bobDeserializedWithNewtonsoftJson.FirstName);
			Console.ReadLine();

			#endregion
		}
	}
}
