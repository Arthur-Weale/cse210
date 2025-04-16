public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor() => _color;

    // Every shape MUST have its own way to get the area
    public abstract double GetArea();
}