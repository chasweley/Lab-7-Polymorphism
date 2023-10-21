namespace Lab_7_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry circle = new Circle(); //Creating new objects for each class
            Geometry ellipse = new Ellipse();
            Geometry parallelogram = new Parallelogram();
            Geometry rectangle = new Rectangle();
            Geometry square = new Square();

            Console.WriteLine($"Area of circle: {circle.Area():0.##}"); //Print out area (using method) for each object rounded to two decimals
            Console.WriteLine($"Area of ellipse: {ellipse.Area():0.##}");
            Console.WriteLine($"Area of paralellogram: {parallelogram.Area():0.##}");
            Console.WriteLine($"Area of rectangle: {rectangle.Area():0.##}");
            Console.WriteLine($"Area of square: {square.Area():0.##}");
        }
    }
}