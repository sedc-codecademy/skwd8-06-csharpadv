using SEDC.SerializationDeserialization.Entities;
using System;
using System.IO;

namespace SEDC.SerializationDeserialization
{
    class Program
    {
        static string directoryPath = @"..\..\..\OurData";
        static string filePath = directoryPath + @"\myFirstJson.json";

        static CustomJsonSerializer Serializer = new CustomJsonSerializer();
        static ReaderWriter ReaderWriter = new ReaderWriter();

        static void Main(string[] args)
        {
            Student martin = new Student() { FirstName = "Martin", LastName = "Panovski", Age = 26, IsPartTime = false };

            if (!Directory.Exists(directoryPath))
                Directory.CreateDirectory(directoryPath);

            if (!File.Exists(filePath))
                File.Create(filePath).Close();

            string martinString = Serializer.SerializeStudent(martin);
            ReaderWriter.WriteFile(filePath, martinString);

            string jsonStudent = ReaderWriter.ReadFile(filePath);
            Student deserializedStudent = Serializer.DeserializeStudent(jsonStudent);

            Console.WriteLine("This is deserialized student: ");
            Console.WriteLine($"{deserializedStudent.FirstName}");
            Console.WriteLine($"{deserializedStudent.LastName}");
            Console.WriteLine($"{deserializedStudent.Age}");
            Console.WriteLine($"{deserializedStudent.IsPartTime}");

            Console.ReadLine();
        }
    }
}
