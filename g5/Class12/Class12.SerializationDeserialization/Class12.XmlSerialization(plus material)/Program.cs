using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Class12.XmlSerialization_plus_material_
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                ID = 1,
                Name = "Andrej",
                Gender = 'M',
                WorkPhone = "78123456",
                Address = "Address 1",
                Skills = new List<string>() { "C#", "ASP.NET", "GIT" }
            };

            // Xml Serialization
            XmlSerializer serializer = new XmlSerializer(employee.GetType());

            //You need to change path to some path on your local drive where you want the xml file to be created
            string path = @"C:\Users\Andrej.Chichakovski\Desktop\C# Advanced\Xml\XmlSerialization.xml";
            using (StreamWriter sw = new StreamWriter(path))
            {
                serializer.Serialize(sw, employee);
            }

            Console.WriteLine("xml object serialized");

            //Xml Deserialization

            Console.WriteLine("Xml object deserialization..");
            Employee empDeserialized;
            using (StreamReader sr = new StreamReader(path))
            {
                empDeserialized = (Employee)serializer.Deserialize(sr);
            }
            Console.WriteLine("xml object deserialized");
            Console.WriteLine(empDeserialized.ToString());

            // List Serialization

            Employee anotherEmpployee = new Employee()
            {
                ID = 3,
                Name = "Bob",
                Gender = 'M',
                WorkPhone = "78123456",
                Skills = new List<string>() { "C#", "CSS/HTML", "Visual Studio" }
            };

            Console.WriteLine("xml list serialization");
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(anotherEmpployee);

            serializer = new XmlSerializer(employees.GetType());

            // You need to change path on your local drive where you want xml file to be created
            string path2 = @"C:\Users\Andrej.Chichakovski\Desktop\C# Advanced\Xml\XmlSerialization-List.xml";
            using (StreamWriter sw = new StreamWriter(path2))
            {
                serializer.Serialize(sw, employees);
            }
            Console.WriteLine("Xml List deserialized");

            // List deserialized

            Console.WriteLine("xml list deserialized.");
            List<Employee> empsDeserialized;
            using (StreamReader sr = new StreamReader(path2))
            {
                empsDeserialized = (List<Employee>)serializer.Deserialize(sr);
            }
            foreach (var e in empsDeserialized)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadLine();
        }
    }
}
