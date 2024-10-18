using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceshape
{
    public class Circle : IShapes
    {
        public double R { get; set; }

        public Circle(double radius)
        {
            R = radius;
        }

        public double Area => 3.14 * R * R;

        public double Perimeter => 2 * 3.14 * R;
    }

}
