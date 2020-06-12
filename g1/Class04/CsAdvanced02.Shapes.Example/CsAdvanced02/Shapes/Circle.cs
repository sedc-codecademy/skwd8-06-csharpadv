using System;

namespace CsAdvanced02.Shapes
{
    public class Circle : Shape
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"A circle with radius {Radius} is drawn.");
        }
    }
}
