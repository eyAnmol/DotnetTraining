using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];

        
        Console.WriteLine($"Please enter {n} numbers:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        
        int min = numbers[0];
        int max = numbers[0];

        
        for (int i = 1; i < n; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        
        Console.WriteLine($"The minimum value is: {min}");
        Console.WriteLine($"The maximum value is: {max}");
    }
}

