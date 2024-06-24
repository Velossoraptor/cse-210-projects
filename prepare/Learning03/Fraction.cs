public class Fraction
{
    private int _top;
    private int _bottom;

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

    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int newTop)
    {
        _top = newTop;
    }

    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int newBottom)
    {
        _bottom = newBottom;
    }

    public String GetFractionString()
    {
        String top = _top.ToString();
        String bottom = _bottom.ToString();
        String fraction = top + "/" + bottom;
        return fraction;
    }
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}