namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Before Generic
            int a = 10, b = 20;
            Console.WriteLine("Before Swap");
            Console.WriteLine($"A = {a}, B = {b}");
            Helper<int>.Swap(ref a, ref b);
            Console.WriteLine("After Swap");
            Console.WriteLine($"A = {a}, B = {b}");
            Console.WriteLine("<=========================>");
            double a1 = 10.11, b1 = 20.22;
            Console.WriteLine("Before Swap");
            Console.WriteLine($"A = {a1}, B = {b1}");
            Helper<double>.Swap(ref a1, ref b1);
            Console.WriteLine("After Swap");
            Console.WriteLine($"A = {a1}, B = {b1}");
            Console.WriteLine("<=========================>");
            Point a2 = new(30, 40), b2 = new(30, 40);
            Console.WriteLine("Before Swap");
            Console.WriteLine($"A = {a2.GetHashCode()}, B = {b2.GetHashCode()}");
            Helper<Point>.Swap(ref a2, ref b2);
            Console.WriteLine("After Swap");
            Console.WriteLine($"A = {a2.GetHashCode()}, B = {b2.GetHashCode()}");
            #endregion
            #region Generic
            Console.WriteLine("<=========================>");
            float af = 50.2f, bf = 60.33f;
            Console.WriteLine("Before Swap");
            Console.WriteLine($"A = {af}, B = {bf}");
            Helper<float>.Swap(ref af, ref bf);
            Console.WriteLine("After Swap");
            Console.WriteLine($"A = {af}, B = {bf}");
            #endregion
            #region Generic Search
            Console.WriteLine("<=========================>");
            Point[] pointsArr = new[]
            {
                new Point(10, 20),
                new Point(60, 70),
                new Point(30, 40),
                new Point(100, 40),
                new Point(50, 40)
            };
            Console.WriteLine(Helper<Point>.SearchArray(pointsArr, new Point(50, 60)));
            Console.WriteLine(Helper<Point>.SearchArray(pointsArr, pointsArr[1]));
            Helper<Point>.BubbleSort(pointsArr);
            Console.WriteLine("<=============Sorted Points============>");
            foreach (var point in pointsArr)
                Console.WriteLine(point);
            #endregion
        }
    }
}