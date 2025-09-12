using System;

class MathProgram
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter another number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n=== Math Class Methods ===");

        // Basic functions
        Console.WriteLine("Maximum : " + Math.Max(num1, num2));
        Console.WriteLine("Minimum : " + Math.Min(num1, num2));

        // Power & Square Root
        Console.WriteLine("num1 ^ num2 : " + Math.Pow(num1, num2));
        Console.WriteLine("Square Root of num1 : " + Math.Sqrt(num1));

        // Absolute value
        Console.WriteLine("Absolute of num1 : " + Math.Abs(num1));

        // Rounding
        Console.WriteLine("Round(num1) : " + Math.Round(num1));
        Console.WriteLine("Ceil(num1)  : " + Math.Ceiling(num1));
        Console.WriteLine("Floor(num1) : " + Math.Floor(num1));

        // Logarithm & PI
        Console.WriteLine("Log(num1)   : " + Math.Log(num1));
        Console.WriteLine("PI constant : " + Math.PI);
    }
}
