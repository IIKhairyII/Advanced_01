using Advanced_01.Range;
using System.Collections;

namespace Advanced_01
{
    internal class Program
    {
        #region Functions
        static void ReverseArrayList(ArrayList arr)
        {
            for (int i = 0; i < arr.Count / 2; i++)
            {
                var elem = arr[i];
                arr[i] = arr[arr.Count - 1 - i];
                arr[arr.Count - 1 - i] = elem;
            }
        }
        static IEnumerable<int> ExtractEvens(IEnumerable<int> collection)
        {
            var result = new List<int>();
            if (collection is null || collection.Count() == 0)
                return result;
            foreach (var item in collection)
            {
                if (item % 2 == 0)
                    result.Add(item);
            }
            return result;
        }
        static int GetFirstNonReapetedChar(string input)
        {
            Dictionary<char, int> dict = new();
            foreach (char c in input)
            {
                if (dict.ContainsKey(c))
                    dict[c]++;
                else
                    dict[c] = 1;

            }
            for (int i = 0; i < input.Length; i++)
            {
                if (dict[input[i]] == 1)
                    return i;
            }
            return -1;
        }
        static void PrintCollection(IEnumerable arr)
        {
            foreach (var item in arr)
                Console.Write($"{item}\t");
            Console.WriteLine();
        }
        #endregion

        static void Main(string[] args)
        {
            #region Problem 1
            int[] arr = { 50, 15, 10, 150, 90, 0, 5, 110 };
            BubbleSort<int>.NormalBubbleSort(arr);
            Console.WriteLine("<=============================>");
            BubbleSort<int>.EnhancedBubbleSort(arr);
            #endregion
            #region Problem 2
            Console.WriteLine("<=============================>");
            Range<char> range = new('a', 'c', new CharRangeOperations());
            Console.WriteLine(range.IsInRange('e'));
            Console.WriteLine(range.Length());
            #endregion
            #region Problem 3
            Console.WriteLine("<=============================>");
            ArrayList arrayList = new() { 1, 10, 5, "Ali", 150, "Karim", 20.5f, 152 };
            ReverseArrayList(arrayList);
            PrintCollection(arrayList);
            #endregion
            #region Problem 4
            Console.WriteLine("<=============================>");
            List<int> numbers = new() { 1, 3, 5, 4, 8, 9, 20, 22, 35, 33, 39, 44 };
            PrintCollection(ExtractEvens(numbers));
            #endregion
            #region Problem 5
            Console.WriteLine("<=============Fixed list================>");
            FixedSizeList<int> myList = new(5);
            myList.Add(10); myList.Add(20);
            Console.WriteLine(myList.Get(1));
            #endregion
            #region Problem 6
            Console.WriteLine("<=============================>");
            string test = "aacd";
            Console.WriteLine(GetFirstNonReapetedChar(test));
            #endregion
        }
    }
}