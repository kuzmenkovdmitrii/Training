using System;

namespace task7
{
    abstract class Shape3D : Shape, IComparable
    {
        public abstract double GetVolume();
        public abstract double GetSurfaceSquare();
        public abstract string GetName();

        public int CompareTo(object obj)
        {
            Shape3D shape = obj as Shape3D;
            if (shape != null)
            {
                return this.GetVolume().CompareTo(shape.GetVolume());
            }
            else
            {
                throw new Exception("Can't compare object");
            }
        }
    }
}
