using System;

class Program
{
    // Non-Generic Calculator Class
    public class Calculator
    {
        // Integer Addition
        public int AddInt(int a, int b)
        {
            return a + b;
        }

        // Double Addition
        public double AddDouble(double a, double b)
        {
            return a + b;
        }

        // String Addition (numbers as string)
        public string AddString(string a, string b)
        {
            double result = Convert.ToDouble(a) + Convert.ToDouble(b);
            return result.ToString();
        }
    }

    static void Main()
    {
        Calculator calc = new Calculator();

        // **Integer Input**
        Console.WriteLine("Enter first integer:");
        int int1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second integer:");
        int int2 = Convert.ToInt32(Console.ReadLine());
        int intResult = calc.AddInt(int1, int2);
        Console.WriteLine("Int Result: " + intResult);

        // **Double Input**
        Console.WriteLine("Enter first double:");
        double d1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second double:");
        double d2 = Convert.ToDouble(Console.ReadLine());
        double doubleResult = calc.AddDouble(d1, d2);
        Console.WriteLine("Double Result: " + doubleResult);

        // **String Input**
        Console.WriteLine("Enter first number as string:");
        string s1 = Console.ReadLine();
        Console.WriteLine("Enter second number as string:");
        string s2 = Console.ReadLine();
        string stringResult = calc.AddString(s1, s2);
        Console.WriteLine("String Result: " + stringResult);
    }
}

