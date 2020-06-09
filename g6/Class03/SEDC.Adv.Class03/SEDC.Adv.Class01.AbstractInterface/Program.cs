using SEDC.Adv.Class01.AbstractInterface.Entities;
using SEDC.Adv.Class01.AbstractInterface.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace SEDC.Adv.Class01.AbstractInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            // var numan = new Human(); // we cannot instanciate object from abstract class

            Developer dev = new Developer("Tosho Todorovski", 30, 999999999,
                new List<string>() { "Javascript", "Css", "Less", "Scss" }, 6);
            Tester test = new Tester("Jill Wayne", 32, 45678943443, 560);
            Operations op = new Operations("Bob Bobsky", 28, 123123123,
                new List<string>() { "Optimus", "ProtoBeat", "PickPro" });
            DevOps devOps = new DevOps("Anne Brown", 22, 123456789, true, false);
            QAEngineer qa = new QAEngineer("Mia Wong", 34, 78932222312,
                new List<string>() { "Selenium" });

            Console.WriteLine("Testing Developer");
            Console.WriteLine(dev.GetInfo());
            dev.Greet("Students");
            Console.WriteLine("-----------------");

            dev.Code();

            Console.WriteLine("Testing Tester");
            Console.WriteLine(test.GetInfo());
            test.Greet("Students");
            Console.WriteLine("-----------------");

            Console.WriteLine("Operation Specialist");
            Console.WriteLine(op.GetInfo());
            op.Greet("Students");
            Console.WriteLine("-----------------");

            Console.WriteLine("DevOps Specialist");
            Console.WriteLine(devOps.GetInfo());
            devOps.Greet("Students");
            Console.WriteLine("-----------------");

            Console.WriteLine("QA engineer Specialist");
            Console.WriteLine(qa.GetInfo());
            qa.Greet("Students");
            Console.WriteLine("-----------------");

            IHuman qa1 = new QAEngineer("Mia Wong ITester", 34, 78932222312,
                new List<string>() { "Selenium" });

            Console.ReadLine();
        }
    }
}
