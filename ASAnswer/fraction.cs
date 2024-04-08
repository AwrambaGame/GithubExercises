using System;

class Fraction
{
    public int Numerator;
    public int Denominator;

    // Constructor
    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        
        Denominator = denominator;
    }

    // Override ToString method
    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}



