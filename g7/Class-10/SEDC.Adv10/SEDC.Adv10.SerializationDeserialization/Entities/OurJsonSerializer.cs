using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv10.SerializationDeserialization.Entities
{
	public static class OurJsonSerializer
	{
		// Serialization
		// Converting a complex type ( Student in our case ) to a more convenient and simple type ( JSON String in our case )
		public static string SerializeStudent(Student student)
		{
			string json = "{"; // Because json always starts with { 
			json += $"\"FirstName\" : \"{student.FirstName}\","; // result -> "FirstName" : "Bob",
			json += $"\"LastName\" : \"{student.LastName}\",";
			json += $"\"Age\" : \"{student.Age}\",";
			json += $"\"IsPartTime\" : \"{student.IsPartTime}\"";
			json += "}";
			return json;
		}

		// Deserialization
		// Converts a simple and convenient type ( JSON String in our case ) back to the complex type of the language we use ( Student in our case )
		public static Student DeserializeStudent(string json)
		{
			try
			{
				// Clean the json file
				// We clean the brackets that we don't need and we clean any special character that we don't need such as \r \n \"
				// We want to get to the name of the property as well as the value it self only. Nothing else. 
				// With Substring we take EVERYTING BETWEEN { } BUT NOT THE { AND } THEMSELVES
				// Example -> {hellosedc} -> { index is 0 -> } index is 10
				// If we do Substring(0, 10) we would get {hellosedc}
				// IF we do Substring(1, 9) we would get hellosedc
				json = json.Trim(); // We remove spaces at the end of the file
				string content = json.Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1) // This gets the content between the brackets without the brackets them selves
				.Replace("\r", "") // Here we remove all \r 
				.Replace("\n", "") // Here we remove all \n ( Issue example in C# -> "Bob\n" )  ( How it looks in the JSON -> "FirstName" : "Bob" \n )
								   // .Replace("\t","")
				.Replace("\"", ""); // Here we remove all \"

				// Process of extracting the properties and values in to a dictionary
				string[] properties = content.Split(","); // Example item : "FirstName : Bob" ( One string )
				Dictionary<string, string> propertiesDectionary = new Dictionary<string, string>();
				foreach (string property in properties)
				{
					string[] pair = property.Split(":"); // Example: ["FirstName ", " Bob"]; ( 2 separate strings )
					propertiesDectionary.Add(pair[0].Trim(), pair[1].Trim()); // Example: {"FirstName", "Bob"} ( Dictionary pair )
				}

				// Create a student object from the dictionary properties and values
				Student student = new Student();
				student.FirstName = propertiesDectionary["FirstName"]; // Goes to the item with key FirstName and returns the value which is "Bob"
				student.LastName = propertiesDectionary["LastName"];
				student.Age = int.Parse(propertiesDectionary["Age"]);
				student.IsPartTime = bool.Parse(propertiesDectionary["IsPartTime"]);

				return student;
			}
			catch (Exception ex)
			{
				Console.WriteLine("The JSON Format was not correctly formatted! Please check the JSON and try again!");
				Console.WriteLine($"ISSUE: {ex.Message}");
				return null;
			}
		}
	}
}
