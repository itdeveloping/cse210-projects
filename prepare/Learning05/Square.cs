public class Square : Shape
{
    private double _side;
    public Square(string color, double side) : base(color)
    {
        _color = color;
        _side = side;
        _name = "square";

    }
    public override double GetArea()
    {
        return Math.Pow(_side, 2);

    }
}