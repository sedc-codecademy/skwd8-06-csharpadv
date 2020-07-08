using Newtonsoft.Json;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SerializationDeserializationApp
{
    class Program
    {
        private static FileFolderService _fileFolderService { get; set; } = new FileFolderService("json");

        static void Main(string[] args)
        {
            // Some initial data
            Car chevrolet = new Car { Brand = "Chevrolet", Model = "Camaro", Year = 2003, Color = "red" };
            Car bmw = new Car { Brand = "BMW", Model = "M3", Year = 2006, Color = "blue" };
            Car fico = new Car { Brand = "Zastava", Model = "Fico", Year = 1983, Color = "white" };

            // Serialization
            string chevroletJson = JsonConvert.SerializeObject(chevrolet);
            string bmwJson = JsonConvert.SerializeObject(bmw);
            string ficoJson = JsonConvert.SerializeObject(fico);

            Console.WriteLine(chevroletJson);
            Console.WriteLine(bmwJson);
            Console.WriteLine(ficoJson);

            // Deserializions
            Car chevroletDeserialized = JsonConvert.DeserializeObject<Car>(chevroletJson);
            Car bmwDeserialized = JsonConvert.DeserializeObject<Car>(bmwJson);
            Car ficoDeserialized = JsonConvert.DeserializeObject<Car>(ficoJson);

            Console.WriteLine(chevroletDeserialized.Model);
            Console.WriteLine(bmwDeserialized.Model);
            Console.WriteLine(ficoDeserialized.Model);


            // Serialization in action
            _fileFolderService.InsertToJSON<Car>(chevrolet);
            _fileFolderService.InsertToJSON<Car>(bmw);
            _fileFolderService.InsertToJSON<Car>(fico);

            // Deserialization in action
            List<Car> cars = _fileFolderService.ReadJSON<Car>().ToList();

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model);
            }

            // Deserialization manual
            string carsJson = _fileFolderService.Read(nameof(Car) + "s");
            List<Car> cars1 = JsonConvert.DeserializeObject<List<Car>>(carsJson);

            Console.ReadKey();
        }

        // fetch("https://swapi.com/ships")
        //      //.then(res => res.text()) // default format of the response(it's just a text)
        //      .then(res => res.json())
        //      .then(data => console.log(data))
    }
}
