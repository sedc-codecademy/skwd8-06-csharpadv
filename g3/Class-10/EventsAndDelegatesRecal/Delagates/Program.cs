using System;

namespace Delagates
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop myShop = new Shop();

            myShop.Inform += () => { };
            myShop.Inform += () => { Console.WriteLine("one-line code"); };
            myShop.Inform += () => 
            { 
                Console.WriteLine("multiple-line code"); 
            };
            myShop.Inform += StaticMethod;

            myShop.AddMethodToDelegate(StaticMethod);

            myShop.Inform();

            Console.ReadKey();
        }

        static void StaticMethod()
        {
            Console.WriteLine("static method code");
        }
    }
}
