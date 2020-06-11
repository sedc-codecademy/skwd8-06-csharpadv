using InterfacesApp.Entities;
using System;

namespace InterfacesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Human();
            //new Employee();

            Developer dejan = new Developer();
            QA alek = new QA();


            byte byteNum = 255;
            int intNum = byteNum;

            JavaScriptDeveloper employee = (JavaScriptDeveloper)dejan;

            Console.ReadKey();
        }
    }
}
