using CsAdvanced02.Shapes;
using System.Collections.Generic;

namespace CsAdvanced02
{
    class Program
    {
        public static List<Shape> Shapes = new List<Shape>();

        static void Main(string[] args)
        {
            Shapes.Add(new Polygon(8));
            Shapes.Add(new Rectangle());
            Shapes.Add(new Triangle());
            Shapes.Add(new Circle(2.5f));

            foreach (var shape in Shapes)
            {
                shape.Draw();

                if (shape is Polygon)
                {
                    (shape as Polygon).PrintTypeOfPolygon();
                }
            }
        }
    }
}
