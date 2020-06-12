using System;

namespace CsAdvanced02.Shapes
{
    public class Rectangle : Polygon
    {
        public Rectangle()
            : base(4)
        { }

        public override void PrintTypeOfPolygon()
        {
            Console.Write("Square - ");
            base.PrintTypeOfPolygon();
        }

        public override void Draw()
        {
            Console.WriteLine("A square is drawn");
        }
    }
}
