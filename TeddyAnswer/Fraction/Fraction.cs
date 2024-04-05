using System;
public class Fraction
{
  public int numerator;
  public int denominator;

  public Fraction(int num, int deno)
  {
    numerator = num;
    denominator = deno;
  }

  public override string ToString()
  {
    return $"{numerator}/{denominator}";
  }
}