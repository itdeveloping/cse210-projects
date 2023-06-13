using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Polymorphism Learning Activity");
        Square square = new Square("red", 10.2);
        Console.WriteLine($"The area of the {square.GetColor()} {square.GetName()} is {Math.Round(square.GetArea())}");
        Rectangle rectangle = new Rectangle("green", 5.2, 6.3);
        Console.WriteLine($"The area of the {rectangle.GetColor()} {square.GetName()} is {Math.Round(rectangle.GetArea())}");
        Circle circle = new Circle("blue", 8.7);
        Console.WriteLine($"The area of the {circle.GetColor()} {square.GetName()} is {Math.Round(circle.GetArea())}");
        Console.WriteLine("\n------Practicing with List:-------");
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("black",4.3));
        shapes.Add(new Rectangle("yellow",3.4,8.9));
        shapes.Add(new Circle("brown",6.5));
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The area of the {shape.GetColor()} {shape.GetName()} is {Math.Round(shape.GetArea())}");
        }        

        Console.WriteLine("\n------------------End of practice");

    }
}