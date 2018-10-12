using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class Shapes
    {
        private List<Shape3D> shapes;

        public Shapes()
        {
            shapes = new List<Shape3D>();
        }

        public void AddShape(Shape3D shape)
        {
            shapes.Add(shape);
        }

        public void Sort()
        {
            shapes.Sort();
        }

        public override string ToString()
        {
            string outString = "";

            foreach (var shape in shapes)
            {
                outString += shape.GetName() + " |Volume:" + shape.GetVolume() +" |Surface square: "+shape.GetSurfaceSquare() + "\n";
            }

            return outString;
        }
    }
}
