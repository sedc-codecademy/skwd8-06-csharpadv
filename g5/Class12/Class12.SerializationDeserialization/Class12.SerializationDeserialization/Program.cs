using Class12.SerializationDeserialization.Entitites;
using Newtonsoft.Json;
using System;
using System.IO;

namespace Class12.SerializationDeserialization
{
    class Program
    {
        static string directoryPath = @"..\..\..\OurData";
        static string filePath = directoryPath + @"\myFirstJson.json";
        static OurJsonSerializer Serializer = new OurJsonSerializer();
        static ReaderWriter ReadWriter = new ReaderWriter();
        static void Main(string[] args)
        {
            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            Student bob = new Student()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Age = 40,
                IsPartTime = false
            };

            //string bobString = Serializer.SerializeStudent(bob);
            //ReadWriter.WriteFile(filePath, bobString);

            string jsonStudent = ReadWriter.ReadFile(filePath);
            Student deseriazlizedStudent = Serializer.DeserializeStudent(jsonStudent);
            Console.WriteLine(deseriazlizedStudent.Age);

            #region Newtonsoft JSON serialize/deserialize

            string bobSerializedNewtonsoft = JsonConvert.SerializeObject(bob);
            Console.WriteLine(bobSerializedNewtonsoft);

            Student bobDeserializedNewtonsoft = JsonConvert.DeserializeObject<Student>(bobSerializedNewtonsoft);
            Console.WriteLine(bobDeserializedNewtonsoft.FirstName);

            #endregion

            Console.ReadLine();
        }
    }
}
