static void Main()
{
    int[] numbers = new int[5];

    
    Console.WriteLine("Enter 5 int:");
    for (int i = 0; i < numbers.Length; i++)  //we could have used 5 here directly as well
    {
        Console.Write($"Enter integer {i + 1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    //took help from google and copied the code for bubble sort
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        for (int j = 0; j < numbers.Length - 1 - i; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                
                int temp = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = temp;
            }
        }
    }
    Console.WriteLine("Sorted integers in ascending order:");
    foreach (int number in numbers)
    {
        Console.WriteLine(number);
    }
}