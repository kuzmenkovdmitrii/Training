using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    class SemiBall : Shape3D
    {
        private readonly Circle circle;

        public SemiBall()
        {
            circle = new Circle(1);
        }

        public SemiBall(Circle circle)
        {
            this.circle = circle;
        }

        public override double GetSquare()
        {
            return circle.GetSquare();
        }

        public override double GetVolume()
        {
            return 0.66666666 * circle.GetSquare();
        }

        public override double GetSurfaceSquare()
        {
            return circle.GetSquare() * 2;
        }

        public override string GetName()
        {
            return "SemiBall";
        }
    }
}
