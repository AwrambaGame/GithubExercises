using System;

public class Fraction
{
    public Fraction(double x,double y)
    public float Denominator=y;
    public float Numerator=x;
    static void Main(string[] args)
    {
        toString();
    }
    void toStrings()
    {
        double z = x / y;
        Console.WriteLine(Convert.ToString(z));
    }
}