using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);

        Console.WriteLine(fraction.GetTop() + fraction.GetBottom());
        Console.WriteLine(fraction2.GetTop() + fraction.GetBottom());
        Console.WriteLine(fraction3.GetTop() + fraction3.GetBottom());

        fraction.SetTop(4);
        fraction.SetBottom(4);
        Console.WriteLine(fraction.GetFractionString());

        Console.WriteLine(fraction3.GetDecimalValue());
        Console.WriteLine(4/4);
    }
}