using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction first = new Fraction();
        Fraction second = new Fraction(6);
        Fraction third = new Fraction(6,7);

        Console.WriteLine(first.GetFractionString());
        Console.WriteLine(first.GetDecimalValue());
        Console.WriteLine(second.GetFractionString());
        Console.WriteLine(second.GetDecimalValue());
        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());

    }
}