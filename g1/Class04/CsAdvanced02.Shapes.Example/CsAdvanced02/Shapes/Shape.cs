namespace CsAdvanced02.Shapes
{
    public abstract class Shape
    {
        public float Width { get; set; }
        public float Height { get; set; }

        public abstract void Draw();
    }
}
