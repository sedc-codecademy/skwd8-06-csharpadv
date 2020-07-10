using Adv10.SerializeDeserialize.Entities;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace Adv10.SerializeDeserialize
{
	class Program
	{
		static string directoryPath = @"..\..\..\OurData";
		static string filePath = directoryPath + @"\myFirstJson.json";
		static OurJsonSerializer Serializer = new OurJsonSerializer();
		static ReaderWriter ReaderWriter = new ReaderWriter();

		static void Main(string[] args)
		{
			#region Our serialize / deserialize methods
			if (!Directory.Exists(directoryPath)) Directory.CreateDirectory(directoryPath);

            // This does not work
            //Console.WriteLine((new Student() { FirstName = "bob" }).ToString());

            // Poor mans Serialize / Deserialize 
            Student bob = new Student()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Age = 40,
                IsPartTime = false
            };

			string bobString = Serializer.SerializeStudent(bob);
			ReaderWriter.WriteFile(filePath, bobString);
			string jsonStudent = ReaderWriter.ReadFile(filePath);
			Student deserializedStudent = Serializer.DeserializeStudent(jsonStudent);
			Console.WriteLine(deserializedStudent.Age);
			Console.ReadLine();
			#endregion

			#region Newtonsoft JSON serialize / deserialize
			string bobSerializedNewtonsoft = JsonConvert.SerializeObject(bob);
			Console.WriteLine(bobSerializedNewtonsoft);

			Student bobDeserializedNewtonsoft = JsonConvert.DeserializeObject<Student>(bobSerializedNewtonsoft);

			Console.WriteLine(bobDeserializedNewtonsoft.FirstName);
			Console.ReadLine();
			#endregion
		}
	}
}
