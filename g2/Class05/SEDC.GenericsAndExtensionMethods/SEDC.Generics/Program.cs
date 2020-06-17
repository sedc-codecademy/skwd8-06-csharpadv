using SEDC.Generics.Helpers;
using SEDC.Generics.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace SEDC.Generics
{
    class Program
    {
        public static GenericDb<Order> OrderDb = new GenericDb<Order>();
        public static GenericDb<Product> ProductDb = new GenericDb<Product>();
        static void Main(string[] args)
        {
            #region Not generic methods
            NotGenericListHelper listHelper = new NotGenericListHelper();
            List<string> strings = new List<string>() { "str1", "str2", "str3" };
            List<int> numbers = new List<int>() { 1, 2, 3, -10 };

            listHelper.GoThroughStrings(strings);
            listHelper.GoThroughInts(numbers);

            listHelper.GetInfoForStrings(strings);
            listHelper.GetInfoForInts(numbers);

            #endregion

            Console.WriteLine("=================== Using Generics =======================");

            #region Generic methods
            //Methods declared in a class GenericListHelper which is a normal class
            //And the methods are generic and can accept all type of Lists.

            GenercListHelper genericListHelper = new GenercListHelper();
            List<bool> checkList = new List<bool>() { true, false, true, true, true};

            genericListHelper.GoThrough(strings);
            genericListHelper.GetInfo(strings);

            genericListHelper.GoThrough(numbers);
            genericListHelper.GetInfo(numbers);

            genericListHelper.GoThrough(checkList);
            genericListHelper.GetInfo(checkList);
            #endregion

            Console.WriteLine("=================== Using Generic class methods =======================");

            #region Generic classes and methods
            //When using a generic class we must instantiate an object of that class 
            //if it is a non-static class. If it is a static class we can use it by just type the name
            //and access the method that we want to use. Don't forget to specify the type in the < > breackets
            
            GenericClassListHelper<string> stringHelper = new GenericClassListHelper<string>();
            GenericClassListHelper<int> intHelper = new GenericClassListHelper<int>();

            List<string> names = new List<string>() { "Martin", "Dejan", "Ivo" };

            stringHelper.GoThrough(names);
            stringHelper.GenericProp = "Something but must be string!";

            intHelper.GoThrough(numbers);
            intHelper.GenericProp = 50;

            //Cannot call static method with an instance of the class GenericClassListHelper
            //stringHelper.GetInfo();

            GenericClassListHelper<bool>.GetInfo(checkList);




            #endregion

            Console.WriteLine("=================== Using Generic class with constraint entity =======================");

            #region Generic class with constraint entity

            //Cannot work since int doesn't inherit or implement BaseEntity
            //GenericDb<int> intDb = new GenericDb<int>();


            OrderDb.Insert(new Order() { Id = 1, Reciever = "Martin", Address = "Test address number 10"});
            OrderDb.Insert(new Order() { Id = 2, Reciever = "Dejan", Address = "Test address number 11"});

            ProductDb.Insert(new Product() { Id = 1, Title = "Lap top", Description = "An amazing lap top!" });
            ProductDb.Insert(new Product() { Id = 2, Title = "Mobile phone", Description = "An amazing mobile phone!" });

            Console.WriteLine("Orders:");
            OrderDb.PrintAll();

            Console.WriteLine("Products:");
            ProductDb.PrintAll();


            Console.WriteLine("Get Order and Product by ID");
            Console.WriteLine("Info about the entities:");
            Console.WriteLine(OrderDb.GetById(1).GetInfo());
            Console.WriteLine(ProductDb.GetById(1).GetInfo());


            Console.WriteLine("Get Order and Product by Index");
            Console.WriteLine(OrderDb.GetByIndex(1).GetInfo());
            Console.WriteLine(ProductDb.GetByIndex(1).GetInfo());


            Console.WriteLine("Remove Order and Product by Id");
            OrderDb.RemoveById(1);
            ProductDb.RemoveById(2);

            Console.WriteLine("Check if itmes were removed");
            OrderDb.PrintAll();
            ProductDb.PrintAll();
















            #endregion


            Console.ReadLine();
        }
    }
}
