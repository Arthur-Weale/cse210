public class Circle : Shape
{
    private double _r;  // radius of circle

    public Circle(string color, double radius) : base(color)
    {
        _r = radius;
    }

    // Overriding the method to use the circle area formula
    public override double GetArea() => _r * _r * Math.PI;
}