using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDay3
{
    public abstract class Appliance
    {
        public abstract void applianceSound();
        
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
}

