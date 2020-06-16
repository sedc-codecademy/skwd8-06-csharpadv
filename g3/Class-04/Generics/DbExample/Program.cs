using Domain.Db;
using Domain.Entities;
using System;

namespace DbExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericDb<Employee> employeeDb = new GenericDb<Employee>(); // Employee is the type that will be passed in "T" parameter
            employeeDb.Create(new Employee { Id = 1, FirstName = "Alek", LastName = "Kocevski" }); // Since we already created an object from GenericDb and passed a Type(Employee), the Create() method now takes 1 parameter of type Employee.
            employeeDb.Create(new Employee { Id = 2, FirstName = "Dejan", LastName = "Blazheski" });
            employeeDb.Create(new Employee { Id = 3, FirstName = "Ivica", LastName = "Janveski" });

            Employee employee = employeeDb.Read(1);
            

            GenericDb<Product> productDb = new GenericDb<Product>(); // In this case Product will be the type that will be passed in "T" parameter
            productDb.Create(new Product { Id = 1, Name = "Stobi Flips", Brand = "Vitaminka" });
            productDb.Create(new Product { Id = 2, Name = "Choicko Stobi Flips", Brand = "Vitaminka" });

            Product product = productDb.Read(2);


            //GenericDb<string> stringDb = new GenericDb<string>(); // We cannot create a GenericDb of type strings, since we added a restriction for the types, the type must inherit from IBaseEntity and string does NOT.
            //stringDb.Create("String that should not be in a database");




            Console.WriteLine(employee.FirstName);
            Console.WriteLine(product.Name);

            Console.ReadKey();
        }
    }
}
