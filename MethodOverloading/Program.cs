using System;

class Program
{
    // Overloaded method 1 - two int parameters
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Overloaded method 2 - three int parameters
    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Overloaded method 3 - double parameters
    public static double Add(double a, double b)
    {
        return a + b;
    }

    static void Main()
    {
        Console.WriteLine("Enter first integer:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second integer:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sum of two integers: " + Add(num1, num2));  // calls method 1

        Console.WriteLine("Enter third integer:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Sum of three integers: " + Add(num1, num2, num3));  // calls method 2

        Console.WriteLine("Enter first double:");
        double d1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second double:");
        double d2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Sum of two doubles: " + Add(d1, d2));  // calls method 3
    }
}


