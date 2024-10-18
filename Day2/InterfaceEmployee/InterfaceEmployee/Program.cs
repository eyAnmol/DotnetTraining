using InterfaceEmployee;

IEmployee manager = new Manager("Ramesh", 24, 99999);

Console.WriteLine($" Name: {manager.Name}");
Console.WriteLine($" Age: {manager.Age}");
Console.WriteLine($" Salary: {manager.Salary}");