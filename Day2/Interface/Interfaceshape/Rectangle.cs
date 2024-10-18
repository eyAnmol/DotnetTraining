using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceshape
{
    public class Rectangle : IShapes
    {
        public double L { get; set; }
        public double W { get; set; }

        public Rectangle(double length, double width)
        {
            L = length;
            W = width;
        }

        public double Area => L * W;

        public double Perimeter => 2 * (L + W);
    }

}
