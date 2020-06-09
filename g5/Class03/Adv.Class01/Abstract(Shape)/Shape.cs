using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Shape_
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public abstract void Draw();

        public void Copy()
        {
            System.Console.WriteLine("Copy shape into clipboard.");
        }
    }
}
