// See https://aka.ms/new-console-template for more information
//using System;
using FractionApp;

namespace Helloworld
{
class Program{
    static void Main(string[] args){
        for (int i = 10; i <= 100; i+=10){
            Console.WriteLine(i);
            }
        Fraction num1 = new Fraction(3,4);
        Console.WriteLine(num1.ToString());

    }
}
    
}

