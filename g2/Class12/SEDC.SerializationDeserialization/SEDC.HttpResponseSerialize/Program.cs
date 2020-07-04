using Newtonsoft.Json;
using SEDC.HttpResponseSerialize.Models;
using SEDC.SerializeServices.Services;
using System;
using System.Collections.Generic;

namespace SEDC.HttpResponseSerialize
{
    class Program
    {
        public static void PrintData(List<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine($"Name: {user.Name}");
                Console.WriteLine($"Username: {user.Username}");
                Console.WriteLine($"Address: {user.Address.Zip}");
                Console.WriteLine($"Lat: {user.Address.GeoLocation.Lat}");
                Console.WriteLine($"Lng: {user.Address.GeoLocation.Lng}");
                Console.WriteLine("---------------------------------------------");
            }
        }

        static void Main(string[] args)
        {
            string url = "https://jsonplaceholder.typicode.com/users";
            
            string usersResult = HttpService.GetData(url);
            List<User> users = JsonConvert.DeserializeObject<List<User>>(usersResult);

            PrintData(users);



            Console.ReadLine();
        }
    }
}
