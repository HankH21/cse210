using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Fraction frac1 = new Fraction();
        Fraction fra2 = new Fraction(5);
        Fraction fra3 = new Fraction(3, 4);


        Console.WriteLine(frac1.GetBottom());
        Console.WriteLine(frac1.GetTop());

        Console.WriteLine(fra2.GetTop());
        Console.WriteLine(fra2.GetBottom());

        Console.WriteLine(fra3.GetTop());
        Console.WriteLine(fra3.GetBottom());

        frac1.SetTop(7);
        frac1.SetBottom(9);

        Console.WriteLine(frac1.GetBottom());
        Console.WriteLine(frac1.GetTop());

        Console.WriteLine(frac1.GetDecimalValue());
        Console.WriteLine(frac1.GetFracionString());

        Console.WriteLine(fra2.GetDecimalValue());
        Console.WriteLine(fra2.GetFracionString());

        Console.WriteLine(fra3.GetDecimalValue());
        Console.WriteLine(fra3.GetFracionString());
    }
}