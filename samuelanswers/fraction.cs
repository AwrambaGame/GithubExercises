using System;

public class Fraction
{
    private int Numerator { get; set; }
    private int Denominator { get; set; }

    // Constructor
    public Fraction(int a, int b)
    {
        Numerator = a;
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        Denominator = b;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
