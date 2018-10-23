namespace task11
{
    class Car
    {
        public string Name { get; set; }

        public Car(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
