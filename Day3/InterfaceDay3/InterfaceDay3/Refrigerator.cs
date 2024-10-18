using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDay3
{
    public class Refrigerator  //we will always have to declare the variables used in interface clas here also cuz that's the only way we can use
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Refrigerator - Brand: {Brand}, Model: {Model}");
        }
    }
}
