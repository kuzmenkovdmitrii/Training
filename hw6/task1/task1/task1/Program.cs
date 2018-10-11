using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Vasia", 19, "Man", 80, 2008);
            Console.WriteLine(student.ToString());
            student.IncreaseCourse(1);
            Console.WriteLine("After increase years of study:");
            Console.WriteLine(student.ToString());

            Teacher teacher = new Teacher("Maria", 50, "Girl", 70, "Professor", 14);
            Console.WriteLine(teacher.ToString());
            teacher.IncreaseExperience(1);
            Console.WriteLine("After increase experience:");
            Console.WriteLine(teacher.ToString());

        }
    }
}
