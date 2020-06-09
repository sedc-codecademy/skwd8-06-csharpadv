using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Shape_
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public override void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }
}
