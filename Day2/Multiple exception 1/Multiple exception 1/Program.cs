try
{

    Console.WriteLine("Enter the first number");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter the second number");
    int num2 = int.Parse(Console.ReadLine());


    int result = num1 / num2;
    Console.WriteLine($"division result {result}");


}
catch (DivideByZeroException)
{
    Console.WriteLine("Denominator is zero.");
}

catch (FormatException)
{
    Console.WriteLine("Invalid input.");
}
catch (OverflowException)
{
    Console.WriteLine("overflow exception");  //**OverflowException** occurs when an arithmetic operation exceeds the limits of the data type used to store the result. 
}