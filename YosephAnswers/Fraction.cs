using System;
namespace Fraction
{
    class Fraction{
        public int Numerator;
        public int Denominator;
        public Fraction(int num1, int num2){
            Numerator = num1;
            Denominator = num2;
        }
        public override string ToString(){
            return $"{Numerator}/{Denominator}";
        }
    }
}