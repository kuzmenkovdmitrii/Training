using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Cube cube = new Cube(new Rectangle(10,10));
            Cylinder cylinder = new Cylinder(new Circle(5.4), 2);
            Parallelepiped parallelepiped = new Parallelepiped(new Rectangle(1,3), 4);
            Prism prism = new Prism(new Triangle(4,2,5), 5);
            SemiBall semiBall = new SemiBall(new Circle(8));

            Shapes shapes = new Shapes();
            shapes.AddShape(cube);
            shapes.AddShape(cylinder);
            shapes.AddShape(parallelepiped);
            shapes.AddShape(prism);
            shapes.AddShape(semiBall);

            Console.WriteLine(shapes.ToString());
            Console.WriteLine("After sort: ");
            shapes.Sort();
            Console.WriteLine(shapes.ToString());
        }
    }
}
