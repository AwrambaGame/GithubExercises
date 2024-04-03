# C# Exercise: Implement Fractions as a Class

In this exercise, you will learn how to implement fractions as a class in C#. 

## Steps:

1. Open your Visual Studio Code editor.

2. Create a new C# file and name it `Fraction.cs`.

3. In the `Fraction.cs` file, the Fraction class have attributes **Numerator** and **Denominator**, a constructor, and a ToString method that prints out the the fraction as a String

4. Save the file.

5. Create a new file used to check your code.

6. Import Fraction class and check if your code is working

You can create an instance of the `Fraction` class and print it as follows:

```csharp
Fraction fraction = new Fraction(1, 2);
Console.WriteLine(fraction);
```

> This should print "1/2" to the console.

## HINT:

Define a `Fraction` class with two properties: `Numerator` and `Denominator`. Also define a constructor that takes two parameters to initialize these properties. The `ToString` method is overridden to provide a string representation of the fraction in the form "Numerator/Denominator".
