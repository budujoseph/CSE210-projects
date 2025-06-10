using System;

class Program
{
    static void Main(string[] args)
    {
        Square sq1 = new Square("Blue", 15);
        // Console.WriteLine(sq1.GetColor());
        // Console.WriteLine(sq1.GetArea());

        Rectangle rectangle1 = new Rectangle("Red", 45, 2.345);
        // Console.WriteLine(rectangle1.GetColor());
        // Console.WriteLine(rectangle1.GetArea());

        Circle circle1 = new Circle("White", 5);
        // Console.WriteLine(circle1.GetColor());
        // Console.WriteLine(circle1.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sq1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shp in shapes)
        {
            string color = shp.GetColor();

            double area = shp.GetArea();
            Console.WriteLine($"The {color} shape has an are of {area:f2}");
        }

    }
}