namespace Demo
{
    internal class Helper
    {
        #region Before Generics

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref Point a, ref Point b)
        {
            Point temp = a;
            a = b;
            b = temp;
        }
        #endregion
        #region Generic
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public static int SearchArray<T>(T[] arr, T value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(value))
                    return i;
            }
            return -1;
        }
        #endregion
    }
}
