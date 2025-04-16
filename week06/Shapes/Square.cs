public class Square : Shape
{
    private double _sideLength;

    public Square(string color, double side) : base(color)
    {
        _sideLength = side;
    }

    // Override the GetArea method to calculate square's area
    public override double GetArea() => _sideLength * _sideLength;
}