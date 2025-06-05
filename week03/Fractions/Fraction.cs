using System.Xml.XPath;

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

    public void SetTop(int topNum)
    {
        _top = topNum;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottomNum)
    {
        _bottom = bottomNum;
    }

    public string GetFracionString()
    {
        string result = $"{_top}/{_bottom}";
        return result;
    }

    public double GetDecimalValue()
    {
        return(double)_top / _bottom;
    }

}

