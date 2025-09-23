using System;

public class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());

        Fraction dec = new Fraction(1, 3);
        Console.WriteLine(dec.GetDecimalValue());

    }

}

    