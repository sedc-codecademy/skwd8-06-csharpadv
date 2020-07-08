using Newtonsoft.Json;
using SEDC.Adv.Class13.SerializeDeserialize.Entities;
using SEDC.Adv.Class13.SerializeDeserialize.OurSerializer;
using System;
using System.IO;

namespace SEDC.Adv.Class13.SerializeDeserialize
{
    class Program
    {
        static string directoryPath = @"..\..\..\OurData\";
        static string filePath = directoryPath + "myFirstJson.json";
        static OurJsonSerializer serializer = new OurJsonSerializer();
        static ReaderWriter readerWriter = new ReaderWriter();
        static void Main(string[] args)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            Student student = new Student()
            {
                FirstName = "Trajan",
                LastName = "Stevkovski",
                Age = 33,
                IsPartTime = true
            };

            // serialize and write in file
            string studentString = serializer.SerializeStudent(student);
            Console.WriteLine(studentString);
            readerWriter.WriteFile(filePath, studentString);

            // read json from file and deserialize
            string jsonContent = readerWriter.ReadFile(filePath);
            Student student1 = serializer.DeserializeStudent(jsonContent);
            Console.WriteLine($"{student1.FirstName} {student1.Age}");

            Console.ReadLine();

            string studentSerializedWithNewtonsoft = JsonConvert.SerializeObject(student);
            Console.WriteLine(studentSerializedWithNewtonsoft);

            Student studentDeserializedWithNewtonsoft =
                JsonConvert.DeserializeObject<Student>(studentSerializedWithNewtonsoft);

            Console.WriteLine($"{studentDeserializedWithNewtonsoft.FirstName} {studentDeserializedWithNewtonsoft.Age}");

            Console.ReadLine();
        }
    }
}
