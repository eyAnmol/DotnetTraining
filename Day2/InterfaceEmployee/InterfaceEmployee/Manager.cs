using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceEmployee
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Manager(string name, int age, double salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }

}
