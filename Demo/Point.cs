namespace Demo
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"Point: X = {X} , Y = {Y}";
        }
        public int CompareTo(Point? other)
        {
            if (other is null)
                throw new NullReferenceException();
            if (X > other.X)
                return 1;
            else
                return -1;
        }
    }
}
