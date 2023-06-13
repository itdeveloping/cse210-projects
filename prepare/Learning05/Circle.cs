public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double radius) : base(color)
    {
        _color = color;
        _radius = radius;
        _name="circle";
    }
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}