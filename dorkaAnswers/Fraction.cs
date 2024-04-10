using System;
namespace Fraction;{

public class Fraction
{
	private int numerator;
	private int denominator;
	public Fraction(int numerator, int denominator)
	{
		this.numerator = numerator;
		this.denominator = denominator;
	}
	public override string  ToString()
	{
		return $"{this.numerator}/{this.denominator}";
	}
}
}