using System;

class OperatorsDemo
{
    static void Main(string[] args)
    {
        // Taking input from user
        Console.Write("Enter first number (a): ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number (b): ");
        int b = Convert.ToInt32(Console.ReadLine());

        // Arithmetic Operators
        Console.WriteLine("\n=== Arithmetic Operators ===");
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));
        Console.WriteLine("a % b = " + (a % b));

        // Assignment Operators
        Console.WriteLine("\n=== Assignment Operators ===");
        int x = a; // start with value of a
        Console.WriteLine("x = " + x);
        x += b;
        Console.WriteLine("x += b => " + x);
        x -= b;
        Console.WriteLine("x -= b => " + x);
        x *= b;
        Console.WriteLine("x *= b => " + x);
        if (b != 0) // avoid divide by zero
        {
            x /= b;
            Console.WriteLine("x /= b => " + x);
            x %= b;
            Console.WriteLine("x %= b => " + x);
        }

        // Comparison Operators
        Console.WriteLine("\n=== Comparison Operators ===");
        Console.WriteLine("a == b : " + (a == b));
        Console.WriteLine("a != b : " + (a != b));
        Console.WriteLine("a > b  : " + (a > b));
        Console.WriteLine("a < b  : " + (a < b));
        Console.WriteLine("a >= b : " + (a >= b));
        Console.WriteLine("a <= b : " + (a <= b));

        // Logical Operators
        Console.WriteLine("\n=== Logical Operators ===");
        bool cond1 = (a > 0);
        bool cond2 = (b > 0);
        Console.WriteLine("cond1 && cond2 : " + (cond1 && cond2));
        Console.WriteLine("cond1 || cond2 : " + (cond1 || cond2));
        Console.WriteLine("!cond1 : " + (!cond1));
    }
}
