namespace Advanced_01
{
    internal class FixedSizeList<T>
    {
        private T[] _items;
        private int _size;
        private int _capacity;
        public FixedSizeList(int capacity)
        {
            if (capacity < 0)
                throw new Exception("Invalid capacity has been entered");

            if (capacity == 0)
                _items = new T[0];
            else
                _items = new T[capacity];
            _capacity = capacity;
        }
        public void Add(T item)
        {
            T[] array = _items;
            int size = _size;
            if ((uint)size < (uint)array.Length)
            {
                _size = size + 1;
                array[size] = item;
            }
            else
                throw new IndexOutOfRangeException();

        }
        public T Get(int index)
        {
            if (index > _capacity - 1)
                throw new IndexOutOfRangeException();
            return _items[index];   

        }
    }
}
