using System;

namespace CsAdvanced02.Shapes
{
    public class Triangle : Polygon
    {
        public Triangle()
            : base(3)
        { }
        public override void PrintTypeOfPolygon()
        {
            Console.Write("Triangle -");
            base.PrintTypeOfPolygon();
        }

        public override void Draw()
        {
            Console.WriteLine("A triangle is drawn.");
        }
    }
}
