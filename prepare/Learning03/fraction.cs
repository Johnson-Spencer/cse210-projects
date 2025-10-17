using System;

public class fraction
{

    private int _Numerator;
    private int _Denominator;

    public fraction()
    {
        _Numerator = 1;
        _Denominator = 1;
    }

    public fraction(int Numerator)
    {
        _Numerator = Numerator;
        _Denominator = 1;
    }

    public fraction(int Numerator, int Denominator)
    {
        _Numerator = Numerator;
        _Denominator = Denominator;
    }

    public string GetFractionString()
    {
        string text = $"{_Numerator}/{_Denominator}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_Numerator / (double)_Denominator;
    }


}