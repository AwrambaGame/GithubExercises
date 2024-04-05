using System;
public class Fraction{
    public int Numerator ;
    public int Denominator;
    public Fraction(int numrtr,int denmtr){
        Numerator=numrtr;
        Denominator=denmtr;
    }
    public override string ToString()
    {
        string frac=Numerator+"/"+Denominator;
        return frac;
    }

}