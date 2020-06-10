using SEDC.Class04.Adv.Polymorphism.Enitities;
using System;

namespace SEDC.Class04.Adv.Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog() { Name = "Sparky", IsGoodBoi = true };
            Cat cat = new Cat() { Name = "Meow", IsLazy = true };

            dog.Eat();
            cat.Eat();
            cat.SayHello();
            cat.SayHello("Trajan");

            //PetStatus(cat);
            //PetStatus(dog, "Bob");
            //PetStatus("bob", dog);
            //PetStatus(cat, "Jill");

            //SayHello();
            //SayHello("Trajan");
            //SayHello("Tosho", ConsoleColor.Yellow);

            Console.ReadLine();
        }

        public static void PetStatus(Dog dog, string ownerName)
        {
            Console.WriteLine($"Hey there {ownerName}");
            if (dog.IsGoodBoi)
            {
                Console.WriteLine("This dog is a good boi :)");
            }
            else
            {
                Console.WriteLine("This dog is not a god boi :(");
            }
        }

        public static void PetStatus(string ownerName, Dog dog)
        {
            Console.WriteLine($"Hey there {ownerName}. Happy to see you again.");
            if (dog.IsGoodBoi)
            {
                Console.WriteLine("This dog is a good boi :)");
            }
            else
            {
                Console.WriteLine("This dog is not a god boi :(");
            }
        }

        public static void PetStatus(Cat cat, string ownerName)
        {
            Console.WriteLine($"Hey there {ownerName}.");
            if (cat.IsLazy)
            {
                Console.WriteLine("This cat is a very lazy :)");
            }
            else
            {
                Console.WriteLine("This cat is not lazy :)");
            }
        }

        public static void PetStatus(Cat cat)
        {
            Console.WriteLine("Hey, a cat without owner");
            if (cat.IsLazy)
            {
                Console.WriteLine("This cat is a very lazy :)");
            }
            else
            {
                Console.WriteLine("This cat is not lazy :)");
            }
        }

        public static string SayHello()
        {
            return "Hello";
        }

        public static string SayHello(string name)
        {
            return $"Hello {name}";
        }

        public static string SayHello(string name, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            return SayHello(name);
        }
    }
}
