using System;

class Fraction
{
    private int _top;
    private int _bottom;

    public void SetNumber()
    {
        _top = 1;
        _bottom = 1;
    }

    public void SetWholeNumber(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public void SetFraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {

        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        double Number = Convert.ToDouble(_top) / Convert.ToDouble(_bottom);
        return Number;
    }
}