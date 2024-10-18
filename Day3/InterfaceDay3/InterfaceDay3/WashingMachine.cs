using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDay3
{
    public class WashingMachine:IAppliance
    {
        public string Brand {  get; set; }
        public string Model { get; set; }
        

        public void DisplayDetails()
        {
            Console.WriteLine($"Washing machine Brand : {Brand} model : {Model}");
        }

    }
}
