using SEDC.AbstractClassesInterfaces.Models;
using SEDC.AbstractClassesInterfaces.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SEDC.AbstractClassesInterfaces
{
    class Program
    {

        public static void HappyBirthday(IHuman human)
        {
            Console.WriteLine($"This is {human.GetInfo()}");
            Console.WriteLine("Happy Birthday!!! We are glad that you are part of our company! :)");
        }

        static void Main(string[] args)
        {
            // Cannot instantiate an abstract class. It gives you a compile time error.

            //Human h1 = new Human();


            Developer martin = new Developer("Martin Panovski", 26, 070222444, new List<string> { "C#", "JS" }, 2);
            Developer dejan = new Developer("Dejan Jovanov", 28, 070222333, new List<string> { "HTML", "JS", "SQL" }, 2);


            Console.WriteLine("=================== Developers ==================");
            martin.Greet(dejan.FullName);
            dejan.Greet(martin.FullName);


            Console.WriteLine(martin.GetInfo());
            Console.WriteLine(dejan.GetInfo());

            dejan.Code();
            martin.Code();


            Console.WriteLine("================== QA ====================");

            QAEngineer qa = new QAEngineer("Ivo", 30, 070444333, new List<string> { "Cypress", "Selenium" });
            Console.WriteLine(qa.GetInfo());
            qa.TestFeature("LogIn");

            Console.WriteLine("================== Operations ====================");

            Operations operations = new Operations("Dragan", 30, 070444333, new List<string> { "SEDC", "Seavus" });
            Console.WriteLine(operations.GetInfo());
            bool status = operations.CheckInfrastructure(404);
            Console.WriteLine(status ? "Status: Ok" : "Status: Failed");


            Console.WriteLine("================= DevOps =======================");
            DevOps devops = new DevOps("Petar", 30, 070444333, true, false);
            Console.WriteLine(devops.GetInfo());
            devops.Code();
            bool statusDevOps = devops.CheckInfrastructure(200);
            Console.WriteLine(statusDevOps ? "Status: Ok" : "Status: Failed");



            Console.WriteLine("================= Interface as a type =======================");
            HappyBirthday(dejan);
            Console.WriteLine();

            HappyBirthday(martin);
            Console.WriteLine();

            HappyBirthday(qa);
            Console.WriteLine();

            HappyBirthday(operations);
            Console.WriteLine();

            HappyBirthday(devops);
            Console.WriteLine();







            Console.ReadLine();
        }
    }
}
