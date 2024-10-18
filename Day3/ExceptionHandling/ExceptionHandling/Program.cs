

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter 1st integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd integer: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine($"Result: {result}");
        }

        //try block creates and object of whatever is written inside it with some output if it matches these two exception then here it comes
        catch (FormatException)
        {
            Console.WriteLine(" Please enter valid integers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
    }
}
