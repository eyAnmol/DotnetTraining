using InterfaceDay3;

class Program
{
    static void Main()
    {
        var washingMachine = new WashingMachine();
        washingMachine.Brand = "LG";
        washingMachine.Model = "LGMAXXXXXX";
        

        var refrigerator = new Refrigerator();
        refrigerator.Brand = "Samsung";
        refrigerator.Model = "SAMFRIDGE";


        var ironbox =new IronBox() { Name="Aplha"};
        ironbox.Name = "Sample";
        

        var dishwasher = new Dishwasher();
        dishwasher.DisplayDetails();
        

        washingMachine.DisplayDetails();
        refrigerator.DisplayDetails();
    }
}
