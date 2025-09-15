using System;

class Program
{
    // Generic Class
    public class Calculator<T>
    {
        public T Add(T a, T b)
        {
            // Convert to double for calculation
            double result = Convert.ToDouble(a) + Convert.ToDouble(b);
            return (T)Convert.ChangeType(result, typeof(T));
        }
    }

    static void Main()
    {
        // **User Input for Integers**
        Console.WriteLine("Enter first integer:");
        int int1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter second integer:");
        int int2 = Convert.ToInt32(Console.ReadLine());

        Calculator<int> intCalc = new Calculator<int>();
        int intResult = intCalc.Add(int1, int2);
        Console.WriteLine("Int Result: " + intResult);

        // **User Input for Doubles**
        Console.WriteLine("Enter first double:");
        double d1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second double:");
        double d2 = Convert.ToDouble(Console.ReadLine());

        Calculator<double> doubleCalc = new Calculator<double>();
        double doubleResult = doubleCalc.Add(d1, d2);
        Console.WriteLine("Double Result: " + doubleResult);

        // **User Input for Strings (numbers as strings)**
        Console.WriteLine("Enter first number as string:");
        string s1 = Console.ReadLine();
        Console.WriteLine("Enter second number as string:");
        string s2 = Console.ReadLine();

        Calculator<string> stringCalc = new Calculator<string>();
        string stringResult = stringCalc.Add(s1, s2);
        Console.WriteLine("String Result: " + stringResult);
    }
}
