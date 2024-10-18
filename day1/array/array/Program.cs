// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.Write("Enter the number of elements: ");
int n = int.Parse(Console.ReadLine());
int[] numbers = new int[n];


Console.WriteLine($"Please enter {n} integers:");
for (int i = 0; i < n; i++)
{
    Console.Write($"Element {i + 1}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}


int sum = 0;
for (int i = 0; i < n; i++)
{
    sum += numbers[i];
}


Console.WriteLine($"The sum of the entered elements is: {sum}");
    