using ConsoleApp.Entites;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer alek = new Developer("Alek", "Kocevsvski", 1801321, new List<string> { "C#", "JS" }, 50);
            QATester dejan = new QATester();
            DevOps vukashin = new DevOps();
            //Human human = new Human(); // Since Human is an abstract class we cannot instantiate an object, it can only be inherited

            alek.SayHi(); // This SayHi method is from Developer class since we override it
            dejan.SayHi(); // This SayHi method is from Human abstract class and has it's implementation(body)
            vukashin.SayHi(); // Same as above

            // Each Eat method belongs to the corresponding object's(alek, dejan, vukashin) Class, since is overriden method of the abstract method Eat from Human class
            alek.Eat("pizza");
            dejan.Eat("pizza");
            vukashin.Eat("pizza");



            List<int> numbers = new List<int> { 12, 3, 2, 1, 22, 4, 33, 2, 2, 2, 132 };
            var filteredNumbers = numbers.Where(num => num > 10); // Returns IEnumarable, and that means it's not actually returning an interface, but an object that inherits from IEnumerable, still it's not a List, it's something else(class)



            Console.ReadKey();
        }

        // DRY - Don't Repeat Yourself
    }
}
