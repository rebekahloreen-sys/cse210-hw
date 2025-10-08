using System;

public class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square squa = new Square("Red", 4);
        shapes.Add(squa);

        Rectangle rect = new Rectangle("Yellow", 9, 3);
        shapes.Add(rect);

        Circle circ = new Circle("Blue", 6);
        shapes.Add(circ);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}