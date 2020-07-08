using Newtonsoft.Json;
using SEDC.SerializationDeserialization.Entities;
using System;
using System.IO;

namespace SEDC.NewtonsoftSerialization
{
    class Program
    {
        static string folderPath = @"..\..\..\Data";
        static string filePath = folderPath + @"\data.json";

        public static void PrintData(Student student)
        {
            Console.WriteLine($"Firstname: {student.FirstName}");
            Console.WriteLine($"Lastname: {student.LastName}");
            Console.WriteLine($"Age: {student.Age}");
            Console.WriteLine($"IsPartTime: {student.IsPartTime}");
            Console.WriteLine("------------------------------------------");
        }


        static void Main(string[] args)
        {
            ReaderWriter rw = new ReaderWriter();

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            Student dejan = new Student() { FirstName = "Dejan", LastName = "Jovanov", Age = 27, IsPartTime = false};
            Student martin = new Student() { FirstName = "Martin", LastName = "Panovski", Age = 26, IsPartTime = false };

            string dejanString = JsonConvert.SerializeObject(dejan);
            string martinString = JsonConvert.SerializeObject(martin);

            rw.WriteFile(filePath, dejanString);
            rw.WriteFile(filePath, martinString);

            Student dejanObj = JsonConvert.DeserializeObject<Student>(dejanString);
            Student martinObj = JsonConvert.DeserializeObject<Student>(martinString);

            Console.WriteLine(rw.ReadFile(filePath));

            Console.WriteLine("----------------- Printing deserialized objects ------------------");
            PrintData(dejanObj);
            PrintData(martinObj);



            Console.ReadLine();
        }
    }
}
