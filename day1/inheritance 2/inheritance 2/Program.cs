using System;

class Employee
{
    public string Name { get; set; }
    public double Sal { get; set; }

    
    public Employee(string name, double salary)
    {
        Name = name;
        Sal = salary;
    }

    
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Salary: {Sal}");
    }
}

class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    
    public Developer(string name, double salary, string programmingLanguage)
        : base(name, salary)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
    }
}

class Program
{
    static void Main()
    {
        
        Developer dev = new Developer("Anmol", 75000000, "C#");

        
        dev.DisplayDetails();
    }
}
