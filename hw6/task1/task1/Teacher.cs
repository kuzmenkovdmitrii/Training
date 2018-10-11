namespace task1
{
    class Teacher : Man
    {
        public string Status { get; set; }
        public int Experience { get; set; }

        public Teacher(string name, int age, string gender, double weight, string status, int experience) : base(name, age, gender, weight)
        {
            Status = status;
            Experience = experience;
        }

        public void IncreaseExperience(int increaseValue)
        {
            Experience++;
        }

        public override string ToString()
        {
            return base.ToString() + "|Status: " + Status + "|Experience: " + Experience;
        }
    }
}
