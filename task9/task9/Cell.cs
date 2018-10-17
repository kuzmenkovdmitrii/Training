namespace task9
{
    class Cell<T>
    {
        public T Value { get; set; }
        public Cell<T> Next { get; set; }

        public Cell()
        {
        }

        public Cell(T value)
        {
            Value = value;
        }
    }
}
