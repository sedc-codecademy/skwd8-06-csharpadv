using Class15.SolidPrinciples.Principles;
using System;

namespace Class15.SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // SOLID

            LengthStringComparing strComp2 = new LengthStringComparing("Bob", "John");
            strComp2.Compare();

            LettersStringComparingGood strComGoood = new LettersStringComparingGood("Bob", "Jill");
            strComGoood.Compare();

        }
    }
}
