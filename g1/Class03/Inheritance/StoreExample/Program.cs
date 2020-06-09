using StoreExample.Enteties;
using System;
using System.Collections.Generic;

namespace StoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Tobaco tobaco = new Tobaco()
            {
                Adress = "ADRESS",
                Products = new List<string>()
                {
                    "Cigarets", "Coca Cola", "Gums"
                }
            };
            tobaco.ShowProductsMenu();
            LiquirStore liquirStore = new LiquirStore()
            {
                Adress = "ADRESS",
                Parkedehicles = 99,
                ParkingCapacity = 100,
                Products = new List<string>()
                {
                    "Jack Daniels", "Skopsko", "Smirnoff"
                }
            };
            var isParkingSpaceAvaliable = liquirStore.HaveAvaliableSpaces();
            if (isParkingSpaceAvaliable)
            {
                Console.WriteLine("You can park your vehicle");
            }
            else
            {
                Console.WriteLine("Sorry no avaliable spaces at the moment");
            }
        }
    }
}
