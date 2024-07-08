using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5);
        Console.WriteLine($"Color: {square.GetColor()}");
        Console.WriteLine($"Area: {square.GetArea()}");

        Rectangle rect = new Rectangle("Purple", 5, 10);
        Console.WriteLine($"Color: {rect.GetColor()}");
        Console.WriteLine($"Area: {rect.GetArea()}");

        Circle circle = new Circle("Green", 6);
        Console.WriteLine($"Color: {circle.GetColor()}");
        Console.WriteLine($"Area: {circle.GetArea()}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rect);
        shapes.Add(circle);

        foreach (Shape shape in shapes){
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }
    }
}