using System;


class Program
{
    static void Main(string[] args)
    {
        // Step 1: Create an IList<int> and add 10 integers
        IList<int> digits = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine("Initial list:");
        for (int i = 0; i < digits.Count; i++)
        {
            Console.Write(digits[i] + " ");
        }
        Console.WriteLine();
        digits.Add(11);
        Console.WriteLine("\nAfter adding 11:");
        for (int i = 0; i < digits.Count; i++)
        {
            Console.Write(digits[i] + " ");
        }
        Console.WriteLine();

        
        digits.Remove(5);    //jahaan bhi pehla occurrence aayega 5 ka usko remove karega
        Console.WriteLine("\nAfter removing 5:");
        for (int i = 0; i < digits.Count; i++)
        {
            Console.Write(digits[i] + " ");
        }
        Console.WriteLine();

        digits.Insert(4, 15);
        Console.WriteLine("\nAfter inserting 15 at index 4:");
        for (int i = 0; i < digits.Count; i++)
        {
            Console.Write(digits[i] + " ");
        }
        Console.WriteLine();







        //QUESTION-2










        IList<string> cities = new List<string> { "Delhi", "mumbai", "BLR", "pune", "Hyderabad" };
        Console.WriteLine("Initial list of cities:");
        for (int i = 0; i <cities.Count; i++)
        {
            Console.Write(cities[i] + " ");
        }
        Console.WriteLine();

        cities.Add("Trivandrum");

        Console.WriteLine("\nAfter adding new city:");
        for (int i = 0; i < cities.Count; i++)
        {
            Console.Write(cities[i] + " ");
        }
        Console.WriteLine();
        cities.Remove("Trivandrum");
        Console.WriteLine("After removing one city");
        for (int i = 0; i < cities.Count; i++)
        {
            Console.Write(cities[i] + " ");
        }
        Console.WriteLine();
        string search = "pune";
        bool cityFound = false;
        for (int i = 0; i < cities.Count; i++)
        {
            if (cities[i] == search)
            {
                cityFound = true;
                break;
            }
        }
        if (cityFound)
        {
            Console.WriteLine($"\n'{search}' is in the list.");
        }
        else
        {
            Console.WriteLine($"\n'{search}' is not in the list.");
        }



    }
}
