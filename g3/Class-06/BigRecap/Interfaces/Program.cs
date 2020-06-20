using Domain.Entities;
using Domain.Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple apple1 = new Apple { Taste = "Sweet", VitaminsAmount = 20 };
            Apple apple2 = new Apple { Taste = "Sweet", VitaminsAmount = 19 };
            Apple apple3 = new Apple { Taste = "Sweet", VitaminsAmount = 21 };
            Orange orange1 = new Orange { Taste = "Sweet/Sour", VitaminsAmount = 17 };
            Orange orange2 = new Orange { Taste = "Sweet/Sour", VitaminsAmount = 19 };
            Steak steakSoDiploma = new Steak { Taste = "Salty", ProteinsAmount = 40 };
            Egg egg1 = new Egg { Taste = "Salty", ProteinsAmount = 30 };

            //List<Apple> apples = new List<Apple> { apple1, apple2, apple3, new JapanApple { JapanProperty = 2 } };
            //List<Orange> oranges = new List<Orange> { orange1, orange2 };
            //List<Egg> eggs = new List<Egg> { egg1 };
            //List<Steak> steaks = new List<Steak> { steakSoDiploma };

            List<IJucable> jucables = new List<IJucable> { apple1, apple2, apple3, orange1, orange2 };
            List<IProtein> proteins = new List<IProtein> { steakSoDiploma, egg1 };

            List<IFood> foods = new List<IFood> { apple1, apple2, apple3, orange1, orange2, steakSoDiploma, egg1 };

            foods.Select(x => x.Taste);

            GenericDb<Apple> appleDb = new GenericDb<Apple>();
            GenericDb<Orange> orangeDb = new GenericDb<Orange>();
            GenericDb<Steak> steakDb = new GenericDb<Steak>();
            GenericDb<Egg> eggDb = new GenericDb<Egg>();
            //GenericDb<string> stringDb = new GenericDb<string>();

            //appleDb appleDb1 = new appleDb()

            appleDb.AddItem(apple1);
            appleDb.AddItem(apple2);
            appleDb.AddItem(apple3);
            orangeDb.AddItem(orange1);
            orangeDb.AddItem(orange2);
            steakDb.AddItem(steakSoDiploma);
            eggDb.AddItem(egg1);


            List<Apple> apples = appleDb.GetItems();
            List<Orange> oranges = orangeDb.GetItems();
            List<Egg> eggs = eggDb.GetItems();
            List<Steak> steaks = steakDb.GetItems();



            Console.WriteLine("Choose 1. Juces 2. Proteins 3. All Food");
            string answer = Console.ReadLine();

            if (int.Parse(answer) == 1)
            {
                //foreach (var apple in apples)
                //{
                //    Console.WriteLine();
                //}

                //foreach (var orange in oranges)
                //{
                //    Console.WriteLine();
                //}

                foreach (var juicable in jucables)
                {
                    Console.WriteLine();
                }
            }
            else if (StrToInt(answer) == 2)
            {
                //foreach (var steak in steaks)
                //{
                //    Console.WriteLine();
                //}

                //foreach (var egg in eggs)
                //{
                //    Console.WriteLine();
                //}

                foreach (var protein in proteins)
                {
                    Console.WriteLine();
                }
            }
            else if (answer.ToInt() == 3)
            {
                //foreach (var jucable in jucables)
                //{
                //    Console.WriteLine();
                //}

                //foreach (var protein in proteins)
                //{
                //    Console.WriteLine();
                //}

                foreach (var food in foods)
                {
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong input");
            }

            Console.ReadKey();
        }

        private static int StrToInt(string str)
        {
            int result;

            if(int.TryParse(str, out result))
            {
                return result;
            }

            return 0;
        }
    }
}
