class Fraction{
    public int Numerator;
    public int Denominator;

    public Fraction(int numerator, int denominator){
        Numerator = numerator;
        Denominator = denominator;
    }

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
