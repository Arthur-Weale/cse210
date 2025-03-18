




public class Fraction
{
    private int _numerator;
    private int _denomenator;

    public Fraction()
    {
        _numerator = 1;
        _denomenator = 1;

        Console.WriteLine(_numerator/_denomenator);
    }

    public Fraction(int wholeNumbers)
    {
        _numerator = wholeNumbers;
        _denomenator = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denomenator = bottom;
    }

    // public void GetTop( )
    // {
    //     _numerator;
    // }
    // public void SetTop(int top)
    // {
    //     _numerator = top;
    // }
    // public void GetBottom()
    // {
    //     _denomenator;
    // }
    // public void SetBottom(int bottom)
    // {
    //     _denomenator = bottom;
    // }

    public string GetFractionString()
    {
        string text = $"{_numerator}/{_denomenator}";
        return text;
    }

    public double GetDecimalValue ()
    {
        return (double)_numerator/(double)_denomenator;
    }
}