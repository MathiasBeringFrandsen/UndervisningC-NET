namespace Lektion3
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Shape(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Shape() : this(1, 1)
        {
        }

        public abstract double Area();
    }
}