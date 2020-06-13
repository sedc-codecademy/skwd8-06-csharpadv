using SEDC.Adc.Class05.Generics.Entities;
using SEDC.Adc.Class05.Generics.Helpers;
using System;
using System.Collections.Generic;

namespace SEDC.Adc.Class05.Generics
{
    class Program
    {
        public static GenericDb<Order> OrderDb = new GenericDb<Order>();
        public static GenericDb<Product> ProductDb = new GenericDb<Product>(); 

        static void Main(string[] args)
        {
            #region GenericMetohds
            var listOfStrings = new List<string>() { "Trajan", "Goce", "Tosho", "Dragan" };
            var listOfIntegers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            var listOfDoubles = new List<double>() { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };

            var helper = new ListHelpers();
            //helper.GoThroughStrings(listOfStrings);
            //helper.GetInfoForStrings(listOfStrings);

            //helper.GoThroughIntegers(listOfIntegers);
            //helper.GetInfoForIntegers(listOfIntegers);

            //helper.GoThrough<string>(listOfStrings);
            //helper.GetInfo<string>(listOfStrings);

            //helper.GoThrough(listOfIntegers);
            //helper.GetInfo(listOfIntegers);

            //helper.GoThrough(listOfDoubles);
            //helper.GetInfo(listOfDoubles);
            #endregion

            #region AddDbData
            OrderDb.Insert(new Order() { Id = 1, Address = "Bob street 29", Receiver = "Bob" });
            OrderDb.Insert(new Order() { Id = 2, Address = "Jill street 31", Receiver = "Jill" });
            OrderDb.Insert(new Order() { Id = 3, Address = "Greg street 11", Receiver = "Greg" });
            ProductDb.Insert(new Product() { Id = 1, Description = "For gaming", Title = "Mouse" });
            ProductDb.Insert(new Product() { Id = 2, Description = "Mechanical", Title = "Keyboard" });
            ProductDb.Insert(new Product() { Id = 3, Description = "64GB", Title = "USB" });
            #endregion

            #region GenericDb
            Console.WriteLine("Orders:");
            OrderDb.PrintAll();
            Console.WriteLine("Products:");
            ProductDb.PrintAll();

            Console.WriteLine("-------------- Get By Id From Order and Product Db -------------");
            Order order = OrderDb.GetById(1);
            Product product = ProductDb.GetById(1);
            Console.WriteLine(order.GetInfo());
            Console.WriteLine(product.GetInfo());

            Console.WriteLine("-------------- Get by Index From Order and Product Db -------------");
            Order order1 = OrderDb.GetByIndex(1);
            Product product1 = ProductDb.GetByIndex(1);
            Console.WriteLine(order1.GetInfo());
            Console.WriteLine(product1.GetInfo());

            Console.WriteLine("-------------- Remove item From Order and Product Db -------------");
            OrderDb.RemoveById(2);
            ProductDb.RemoveById(2);

            Console.WriteLine("Orders:");
            OrderDb.PrintAll();
            Console.WriteLine("Products:");
            ProductDb.PrintAll();
            #endregion


            Console.ReadLine();
        }
    }
}
