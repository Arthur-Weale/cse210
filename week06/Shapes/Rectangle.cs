public class Rectangle : Shape
{
    private double _width;
    private double _height;

    public Rectangle(string color, double width, double height) : base(color)
    {
        _width = width;
        _height = height;
    }

    // Calculate the area for a rectangle
    public override double GetArea() => _width * _height;
}