public class Animal
{
    public string Name { get; set; }
    public string Type { get; set; }
}

public class Bird : Animal
{
    public bool CanFly { get; set; }
}

public class Fish : Animal
{
    public bool CanSwim { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Bird myBird = new Bird
        {
            Name = "crow",
            Type = "Bird",
            CanFly = true
        };

        Fish myFish = new Fish
        {
            Name = "Goldfish",
            Type = "Fish",
            CanSwim = true
        };

        Console.WriteLine($"Animal: {myBird.Name}, Type: {myBird.Type}, Can Fly: {myBird.CanFly}");
        Console.WriteLine($"Animal: {myFish.Name}, Type: {myFish.Type}, Can Swim: {myFish.CanSwim}");
    }
}