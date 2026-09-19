using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(); // 1/1
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f2 = new Fraction(5); // 5/1
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Fraction f3 = new Fraction(3, 4); // 3/4
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}

public class Fraction
{
    private int _numerator;
    private int _denominator;

    // Constructors (Demonstrating Constructor Overloading)
    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int top)
    {
        _numerator = top;
        _denominator = 1;
    }

    public Fraction(int top, int bottom)
    {
        _numerator = top;
        SetDenominator(bottom);
    }

    // Getters and Setters
    public int GetNumerator() => _numerator;

    public void SetNumerator(int value) => _numerator = value;

    public int GetDenominator() => _denominator;

    public void SetDenominator(int value)
    {
        if (value == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        _denominator = value;
    }
    // Helper Methods
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}