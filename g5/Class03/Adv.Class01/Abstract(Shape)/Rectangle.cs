using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Shape_
{
    public class Rectangle : Shape
    {
        public string Name { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle...");
        }
    }
}
