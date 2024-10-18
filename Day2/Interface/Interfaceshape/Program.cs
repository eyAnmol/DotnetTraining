


namespace Interfaceshape
{
    class Program
    {
        static void Main(string[] args)
        {
            IShapes circle = new Circle(5);
            Console.WriteLine($"Cir: A = {circle.Area}, P = {circle.Perimeter}");

            IShapes rectangle = new Rectangle(4, 7);
            Console.WriteLine($"Rect: A = {rectangle.Area}, P = {rectangle.Perimeter}");
        }
    }
}
