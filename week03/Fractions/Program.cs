using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction1: {fraction1.GetFractionString()}");
        Console.WriteLine($"Fraction1: {fraction1.GetDecimalValue()}");

        Fraction fraction2 = new Fraction(6);
        Console.WriteLine($"Fraction2: {fraction2.GetFractionString()}");
        Console.WriteLine($"Fraction2: {fraction2.GetDecimalValue()}");

        Fraction fraction3 = new Fraction(6, 7);
        Console.WriteLine($"Fraction3: {fraction3.GetFractionString()}");
        Console.WriteLine($"Fraction3: {fraction3.GetDecimalValue()}");

        // Fraction bottom1 = new Fraction();
        // bottom1.SetBottom(5); 
        // Console.WriteLine(bottom1.GetFractionString());
        // Console.WriteLine(bottom1.GetDecimalValue());


        // Fraction top1 = new Fraction();
        // top1.SetTop(4);
        // Console.WriteLine(top1.GetTop());




    }
}