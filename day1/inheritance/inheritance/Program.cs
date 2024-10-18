using System;

class Vehicle
{
    
    public virtual void Drive()
    {
        Console.WriteLine(" vehicle  driving.");
    }
}

class Car : Vehicle
{
    
    public override void Drive()
    {
        Console.WriteLine(" car driving.");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.Drive();
        Vehicle mycehicle =new Car();
        mycehicle.Drive();
    }
}
