
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        Square square = new Square("Square", "Blue", 4);
        Rectangle rectangle = new Rectangle("Rectangle", "Yellow", 4, 6);
        Circle circle = new Circle("Circle", "Red", 5);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string shapeName = s.GetShapeName();
            string color = s.GetColor();
            double area = s.GetArea();


            Console.WriteLine($"The {color} {shapeName} is {area}cm^2");
        }

    }
}
