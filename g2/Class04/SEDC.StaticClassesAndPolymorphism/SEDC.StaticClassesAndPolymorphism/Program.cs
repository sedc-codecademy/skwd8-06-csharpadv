using SEDC.StaticClassesAndPolymorphism.DB;
using SEDC.StaticClassesAndPolymorphism.Models;
using SEDC.StaticClassesAndPolymorphism.Polymorphism;
using System;
using System.Linq;
using System.Reflection.Metadata;

namespace SEDC.StaticClassesAndPolymorphism
{

    //Static class with static methods for simple math operations
    public static class Calculate
    {
        public static double PI { get; set; } = 3.14159265359;

        public static int Max(int val1, int val2)
        {
            return val1 > val2 ? val1 : val2;
        }

        public static int Min(int val1, int val2)
        {
            return val1 < val2 ? val1 : val2;
        }

        public static int Pow(int number, int value)
        {
            int result = 1;
            while (value > 0)
            {
                result *= number;
                value--;
            }
            return result;
        }

    }


    class Program
    {
        //Compile time polymorphism
        public static void PetStatus(Dog dog, string owner)
        {
            if (dog.IsGoodBoy)
            {
                Console.WriteLine($"Hey there {owner}, your pet is good boy!");
            }
            else
            {
                Console.WriteLine($"Hey there {owner}, your pet is not so good boy!");
            }

        }

        //Signature is different when the order of the input parameters do not match
        public static void PetStatus(string owner, Dog dog)
        {
            if (dog.IsGoodBoy)
            {
                Console.WriteLine($"Hey there {owner}, your pet is still good boy!");
            }
            else
            {
                Console.WriteLine($"Hey there {owner}, your pet is still not so good boy!");
            }
        }

        /// <summary>
        ///   It prints a message in the console depending on the laziness of the cat
        /// </summary>
        /// <param name="cat"></param>
        /// <param name="owner"></param>
        public static void PetStatus(Cat cat, string owner)
        {
            if (cat.IsLazy)
            {
                Console.WriteLine($"Hey there {owner}, your cat is LAZY!!!");
            }
            else
            {
                Console.WriteLine($"Hey there {owner}, your cat is broken!");
            }
        }

        public static void PetStatus(string owner, Cat cat)
        {
            if (cat.IsLazy)
            {
                Console.WriteLine($"Hey there {owner}, your cat is still LAZY!!!");
            }
            else
            {
                Console.WriteLine($"Hey there {owner}, your cat is broken!");
            }
        }


        public static void PetStatus(string owner, Cat cat, Dog dog)
        {
            if (cat.IsLazy && dog.IsGoodBoy)
            {
                Console.WriteLine($"Hey there {owner}, pets are awesome!");
            }
            else
            {
                Console.WriteLine($"Hey there {owner}, somethings wrong with your both pets!");
            }
        }




        //This is for the Order system example under the Order system region
        static User _currentUser;

        static void Main(string[] args)
        {

            #region Static classes and static members

            //An instance of a static class cannot be created!
            //Calculate calc = new Calculate();

            //Console.WriteLine("===================== Using custom static methods =======================");
            //Console.WriteLine(Calculate.PI);
            //Console.WriteLine(Calculate.Max(10, 25));
            //Console.WriteLine(Calculate.Min(10, 25));
            //Console.WriteLine(Calculate.Pow(2, 3));

            //Console.WriteLine("===================== Using Math static methods ========================");
            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.Max(10, 25));
            //Console.WriteLine(Math.Min(10, 25));
            //Console.WriteLine(Math.Pow(2, 3));


            //Format is a static member of the String class
            //Console.WriteLine(String.Format("{0} {1}", "Martin", "Panovski"));




            #endregion

            #region Static members in a non static class

            //Pet dog = new Pet() { Name = "Bucky", Color = "Brown" };

            // Cannot acces a static method with an instance of a non-static class
            //dog.Speak();

            //Console.WriteLine("The dog's name is" + dog.Name);
            //Console.WriteLine("It is " + dog.Color);
            //Pet.Speak();
            #endregion

            #region Order system
            Console.Clear();
            Console.WriteLine("Welcome to the ordering menu!");

            Console.WriteLine("Choose a User:");
            OrdersTmpDB.ListUsers();
            int userChoice = TextHelper.ValidateNumberInput(Console.ReadLine());
            
            _currentUser = OrdersTmpDB.Users[userChoice - 1];

            Console.Clear();
            Console.WriteLine("Orders menu");
            Console.WriteLine("1) Check Orders");
            Console.WriteLine("2) Add new Order");
            int menuChoice = TextHelper.ValidateNumberInput(Console.ReadLine());

            if (menuChoice == 1)
            {
                Console.Clear();
                _currentUser.PrintUserOrders();
            }
            else if (menuChoice == 2)
            {
                Console.Clear();
                Order newOrder = new Order();
                Console.WriteLine("Enter order name:");
                newOrder.Title = Console.ReadLine();
                Console.WriteLine("Enter order description:");
                newOrder.Description = Console.ReadLine();
                OrdersTmpDB.InsertOrder(_currentUser.Id, newOrder);
            }

            #endregion

            #region Polymorphism

            Dog dog = new Dog
            {
                Name = "Sharko",
                Color = "Black",
                IsGoodBoy = true
            };

            Cat cat = new Cat
            {
                Name = "Garfield",
                Color = "Orange",
                IsLazy = true
            };


            //Compile time polymorphism. One method name, but different signature
            PetStatus("Martin", dog);
            PetStatus("Dejan", dog);
            PetStatus("Ivo", cat, dog);



            //Runtime polymorphism. One method with same name, but different overridings in the
            //inheritance chain. From the parent class to the child classes
            dog.Speak();
            cat.Speak();



            #endregion


            Console.ReadLine();
        }
    }
}
