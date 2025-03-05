using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Circle flat = new Circle(5, "blue");
        Rectangle rex = new Rectangle(3, 4, "Teal");
        Square squack = new Square(2.5, "red");
        shapes.Add(flat);
        shapes.Add(rex);
        shapes.Add(squack);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}