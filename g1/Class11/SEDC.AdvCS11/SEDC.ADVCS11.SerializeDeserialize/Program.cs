using SEDC.ADVCS11.SerializeDeserialize.Entities;
using SEDC.ADVCS11.SerializeDeserialize.Services;
using System.IO;
using Newtonsoft.Json;
// Alias
using SystemJson = System.Text.Json.Serialization;

namespace SEDC.ADVCS11.SerializeDeserialize
{
    class Program
    {
        private static string directoryPath = Directory.GetCurrentDirectory();
        private static string filePath = Path.Combine(directoryPath, "testJson.json");
        private static JsonSerializerService serializer;
        private static ReaderWriterService readerWriter;

        static void Main(string[] args)
        {
            serializer = new JsonSerializerService();
            readerWriter = new ReaderWriterService();

            Student bob = new Student()
            {
                FirstName = "Bob",
                LastName = "Bobsky",
                Age = 37,
                Pets = new string[] { "Dog1", "Dog2", "Dog3", "Cat1" }
            };

            string jsonString = serializer.SerializeStudent(bob);
            readerWriter.WriteFile(filePath, jsonString);

            string jsonFromFile = readerWriter.ReadFile(filePath);
            Student student = serializer.DeserializeStudent(jsonFromFile);

            #region NewtonsoftJson
            
            string newtonsoftJasonString = JsonConvert.SerializeObject(student);
            Student newtonsoftStudent = JsonConvert.DeserializeObject<Student>(jsonFromFile);

            #endregion
        }
    }
}
