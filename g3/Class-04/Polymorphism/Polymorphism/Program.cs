using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Getters and setters explanation
            //Square square = new Square(4);
            //square.Length = 5;
            //double lengthOfThisSquare = square.Length;

            //Dynamic Polymorphism
            Circle circle = new Circle(3);
            Square square = new Square(5);
            Rectangle rectangle = new Rectangle(4, 5);

            //circle.Area();
            //square.Area();
            //rectangle.Area();

            List <Shape> shapes = new List<Shape>();
            shapes.Add(circle);
            shapes.Add(square);
            shapes.Add(rectangle);

            foreach (var shape in shapes)
            {
                shape.Area();
            }

            //Static Polymorphism
            //int x, string y != string x, int y ... as parameters
            circle.Area();
            circle.Area(4);

            rectangle.Area();
            rectangle.Area(9);
            rectangle.Area(5, 6);

            Console.ReadKey();
        }
    }
}
