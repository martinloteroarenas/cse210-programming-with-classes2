using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3,4);
        Fraction f4 = new Fraction(1,3);

        int f1Top = f1.GetTop();
        int f1Bottom = f1.GetBottom();
        string f1String = f1.GetFractionString(f1Top, f1Bottom);
        double f1Decimal = f1.GetDecimalValue(f1Top, f1Bottom);
        Console.WriteLine($"{f1String}");
        Console.WriteLine($"{f1Decimal}");

        int f2Top = f2.GetTop();
        int f2Bottom = f2.GetBottom();
        string f2String = f2.GetFractionString(f2Top, f2Bottom);
        double f2Decimal = f2.GetDecimalValue(f2Top, f2Bottom);
        Console.WriteLine($"{f2String}");
        Console.WriteLine($"{f2Decimal}");

        int f3Top = f3.GetTop();
        int f3Bottom = f3.GetBottom();
        string f3String = f3.GetFractionString(f3Top, f3Bottom);
        double f3Decimal = f3.GetDecimalValue(f3Top, f3Bottom);
        Console.WriteLine($"{f3String}");
        Console.WriteLine($"{f3Decimal}");

        int f4Top = f4.GetTop();
        int f4Bottom = f4.GetBottom();
        string f4String = f4.GetFractionString(f4Top, f4Bottom);
        double f4Decimal = f4.GetDecimalValue(f4Top, f4Bottom);
        Console.WriteLine($"{f4String}");
        Console.WriteLine($"{f4Decimal}");
    }
}