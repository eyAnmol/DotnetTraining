using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDay3
{
    public interface IAppliance
    {
        string Brand { get; }
        string Model { get;  }
        void DisplayDetails();
    }
}
