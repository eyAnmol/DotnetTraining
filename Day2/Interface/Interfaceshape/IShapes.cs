using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaceshape
{
    public interface IShapes
    {
        double Area { get; }   //we just want to calculate the values not edit thats why only get no set
        double Perimeter { get; }

        double CalculateArea (double area , double perimeter);
    }

}
