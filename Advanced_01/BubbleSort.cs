using System.Diagnostics;

namespace Advanced_01
{
    internal static class BubbleSort<T> where T : struct, IComparable
    {
        public static void NormalBubbleSort(T[] array)
        {
            Stopwatch timer = new();
            timer.Start();
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            timer.Stop();
            Console.WriteLine("Sorted Array:");
            PrintArray(array);
            Console.WriteLine($"Normal bubble sort algo took {timer.Elapsed} to be executed");
        }
        public static void EnhancedBubbleSort(T[] arr)
        {
            Stopwatch timer = new();
            timer.Start();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        T val = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = val;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

            }
            timer.Stop(); Console.WriteLine("Sorted Array:");
            PrintArray(arr);
            Console.WriteLine($"Optimized bubble sort algo took {timer.Elapsed} to be executed");
        }

        public static void PrintArray(T[] arr)
        {
            foreach (var item in arr)
                Console.Write($"{item}\t");
            Console.WriteLine();
        }
    }
}
