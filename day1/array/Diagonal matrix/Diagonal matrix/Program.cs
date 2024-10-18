using System;

class Program
{
    static void Main()
    {
        
        int[,] matrix = new int[3, 3];

        
        Console.WriteLine("Enter the elements of the 3x3 matrix:");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Element please");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        
        int diagonalSum = 0;

        for (int i = 0; i < 3; i++)
        {
            diagonalSum += matrix[i, i]; 
        }

        
        Console.WriteLine($" sum of the diagonal elements: {diagonalSum}");









        // reversing array











        int[] array = new int[6];

        
        Console.WriteLine("Enter 6 integers:");

        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        
        Array.Reverse(array);

        
        Console.WriteLine("Reversed array:");
        for (int i = 0; i < 6; i++)
        {
            Console.Write(array[i] + " ");
        }



    }
}
