namespace Advanced_01.Range
{
    internal class Range<T> where T : IComparable
    {
        public T MinVal { get; set; }
        public T MaxVal { get; set; }
        private readonly IRangeOperations<T> _operations;
        public Range(T minVal, T maxVal, IRangeOperations<T> operations)
        {
            if (minVal.CompareTo(maxVal) > 0)
                throw new ArgumentException("The entered values are not correct");
            MinVal = minVal;
            MaxVal = maxVal;
            _operations = operations ?? throw new ArgumentNullException(nameof(operations));
        }
        public bool IsInRange(T value) =>
            MinVal.CompareTo(value) <= 0 && MaxVal.CompareTo(value) >= 0;

        public long Length() =>
            _operations.CalculateLength(MinVal, MaxVal);


    }
}
