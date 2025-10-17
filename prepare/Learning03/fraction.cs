using System;

public class Fraction
{

    private int _Numerator;
    private int _Denominator;

    public Fraction()
    {
        _Numerator = 1;
        _Denominator = 1;
    }

    public Fraction(int Numerator)
    {
        _Numerator = Numerator;
        _Denominator = 1;
    }

    public Fraction(int Numerator, int Denominator)
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