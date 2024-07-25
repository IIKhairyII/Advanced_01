namespace Advanced_01.Range
{
    internal class IntRangeOperations : IRangeOperations<int>
    {
        public long CalculateLength(int min, int max) =>
            max - min + 1;
    }
}
