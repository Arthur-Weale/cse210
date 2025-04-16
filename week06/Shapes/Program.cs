using System;

class Program
{
    static void Main(string[] args)
    {
         // Make a list that can hold any shape
        List<Shape> shapes = new List<Shape>();

        // Create different shapes
        shapes.Add(new Square("Red", 3));
        shapes.Add(new Rectangle("Blue", 4, 5));
        shapes.Add(new Circle("Green", 6));

        // Loop through each shape and show its color and area,
        // even though they are all treated as "Shape"
        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()}.");
        }
    }
}