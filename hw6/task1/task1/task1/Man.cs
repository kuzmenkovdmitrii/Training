namespace task1
{
    class Man
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double Weight { get; set; }

        public Man(string name, int age, string gender, double weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
        }

        public override string ToString()
        {
            return "Name: " + Name + "|Age: " + Age + "|Gender: " + Gender + "|Weight: " + Weight;
        }
    }
}
