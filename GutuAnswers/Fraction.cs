using System;

namespace GutuAnswers
{
    public class Fraction 
    {
        //attributes 
        public int numerator;
        public int denominator;

        //constractor with 2 arguments
        public Fraction(int num1, int num2)
        {
            numerator = num1;
            denominator = num2;
        }


        //ToString() method
        public override string ToString()
        {
            string str = numerator + "/" + denominator;
            return str;
        }

    }

    
        
}