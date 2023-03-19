using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square ("Red", 12);
        Rectangle r = new Rectangle ("Green", 12, 10);
        Circle c = new Circle ("Blue", 10);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (var shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape area is= {shape.GetArea()}");
        }
    }
}