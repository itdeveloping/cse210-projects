public class Fraction
{
    /*The class should have two attributes for the top and bottom numbers. Make sure the attributes are private.*/
    private int _top;
    private int _bottom;

    /*Create the following constructors:
    Constructor that has no parameters that initializes the number to 1/1.
    Constructor that has one parameter for the top and that initializes the denominator to 1. So that if you pass in the number 5, the fraction would be initialized to 5/1.
    Constructor that has two parameters, one for the top and one for the bottom.*/
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //Create getters and setters for both the top and the bottom values.
    public void GetTop()
    {
        Console.WriteLine(_top);
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    //Create methods to return the representations

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
    }
    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }

}
