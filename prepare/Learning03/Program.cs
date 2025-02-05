using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac = new Fraction();
        Fraction frac2 = new Fraction();
        Fraction frac3 = new Fraction();
        Fraction frac4 = new Fraction();
        frac.SetNumber();
        frac2.SetWholeNumber(5);
        frac3.SetFraction(3, 4);
        frac4.SetFraction(1, 3);
        Console.WriteLine("Hello Learning03 World!");
        Console.WriteLine($"{frac.GetFractionString()}");
        Console.WriteLine($"{frac.GetDecimalValue()}");
        Console.WriteLine($"{frac2.GetFractionString()}");
        Console.WriteLine($"{frac2.GetDecimalValue()}");
        Console.WriteLine($"{frac3.GetFractionString()}");
        Console.WriteLine($"{frac3.GetDecimalValue()}");
        Console.WriteLine($"{frac4.GetFractionString()}");
        Console.WriteLine($"{frac4.GetDecimalValue()}");
    }
}