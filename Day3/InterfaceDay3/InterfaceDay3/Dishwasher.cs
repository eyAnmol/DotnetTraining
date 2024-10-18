using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDay3
{
    public class Dishwasher : IAppliance
    {
        public string Brand => "samsung";
        public string Model => "Automatic";   //used for giving values 

        public void DisplayDetails()
        {
            Console.WriteLine($" the brand is {Brand} model is {Model}");
        }
    }
}
