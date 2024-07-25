namespace Advanced_01.Range
{
    internal class CharRangeOperations : IRangeOperations<char>
    {
        public long CalculateLength(char min, char max) =>
            max - min + 1;
    }
}
