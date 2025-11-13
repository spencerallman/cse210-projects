using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(5, "yellow");
        Rectangle rectangle = new Rectangle(6, 5, "red");
        Circle circle = new Circle(3, "blue");

        List<Shape> shapeList = new List<Shape>();
        shapeList.Add(square);
        shapeList.Add(rectangle);
        shapeList.Add(circle);

        foreach(Shape shape in shapeList)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}