namespace task1
{
    class Student : Man
    {
        public int YearsOfStudy { get; set; }

        public Student(string name, int age, string gender, double weight, int yearsOfStudy) : base(name, age, gender, weight)
        {
            YearsOfStudy = yearsOfStudy;
        }

        public void IncreaseCourse(int increaseValue)
        {
            YearsOfStudy += increaseValue;
        }

        public override string ToString()
        {
            return base.ToString() + "|Years of study: " + YearsOfStudy;
        }
    }
}
