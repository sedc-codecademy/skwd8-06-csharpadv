using System;

namespace CsAdvanced02.Shapes
{
    public class Polygon : Shape
    {
        public int NumberOfPoints { get; }

        public Polygon(int numberOfPoints)
        {
            NumberOfPoints = numberOfPoints;
        }

        public override void Draw()
        {
            Console.WriteLine("A polygon is drawn.");
        }

        public virtual void PrintTypeOfPolygon()
        {
            Console.WriteLine($"Polygon with {NumberOfPoints} number of points.");
        }
    }
}
