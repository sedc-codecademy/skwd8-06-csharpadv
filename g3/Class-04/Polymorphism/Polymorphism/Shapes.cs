using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Polymorphism
{
    public class Shape :Object
    {
        public virtual void Area()
        {
            Console.WriteLine($"This is the base method calling");
        }
        public virtual void Area(double x)
        {
            Console.WriteLine($"This is the base method calling with 1 parameter");
        }
        public virtual void Area(double x, double y)
        {
            Console.WriteLine($"This is the base method calling with 2 parameters");
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override void Area()
        {
            Console.WriteLine($"The area of the circle is: {3.14 * Math.Pow(Radius, 2)}");

            base.Area();
        }
        public override void Area(double radius)
        {
            Console.WriteLine($"The area of the circle is: {3.14 * Math.Pow(radius, 2)}");
        }
    }
    public class Square : Shape
    {
        private double _length;

        public double Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public Square() { }
        public Square(double length)
        {
            Length = length;
        }
        public override void Area()
        {
            Console.WriteLine($"The area of the square is: {Math.Pow(Length,2)}");

            base.Area();
        }
    }
    public class Rectangle: Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public Rectangle() { }
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override void Area()
        {
            Console.WriteLine($"The area of the rectangle is: {Height * Width}");
            base.Area();
        }
        public override void Area(double x)
        {
            base.Area(x);
        }
        public override void Area(double height, double width)
        {
            Console.WriteLine($"The area of the rectangle is: {height * width}");
        }
    }
}
