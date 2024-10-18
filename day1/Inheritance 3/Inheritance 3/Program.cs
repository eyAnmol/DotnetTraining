public class Device
{
    public virtual void PowerOn()  //ye jo virtual keyword hai , we use this keyword so that in base/child class we can overrride this keyword
    {
        Console.WriteLine("power on from device");
    }
}

public class Laptop : Device
{
    public override void PowerOn()
    {
        Console.WriteLine("power on from laptop");
    }
}

public class Smartphone : Device
{
    public override void PowerOn()
    {
        Console.WriteLine("power on from smartphone");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Device myLaptop = new Laptop();
        Device mySmartphone = new Smartphone();

        myLaptop.PowerOn();    //laptop ka poweron method
        mySmartphone.PowerOn();   //smartphone ka power on method
    }
}