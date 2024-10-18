

public class Appliance
{
    public virtual void Start()
    {
        Console.WriteLine("Appliance ");
    }
}

public class WashingMachine : Appliance
{
    public  override void Start()
    {
        Console.WriteLine("Washing machine ");
    }
}

public class SmartWashingMachine : WashingMachine
{
    public override void Start()
    {
        Console.WriteLine("Smart washing machine ");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SmartWashingMachine mySmartWasher = new SmartWashingMachine();
        mySmartWasher.Start();  
    }
}
