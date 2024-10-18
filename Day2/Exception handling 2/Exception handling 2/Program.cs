

public class NegativeNumberException : Exception   //inheriting this class becomes essential to make it standard exception 
    // to make it custom exception as well
{
    public NegativeNumberException(string message) : base(message) { }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                throw new NegativeNumberException("-ve number.");
            }

            Console.WriteLine($"You entered: {number}");
        }
        catch (NegativeNumberException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}
