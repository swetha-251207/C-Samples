using System;

class Program
{
    // Method with Parameters, Default Parameter, and Return Value
    public static int Add(int a, int b = 10)  // b has default value
    {
        return a + b;  // Return value
    }

    // Method with Named Arguments
    public static void DisplayInfo(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }

    static void Main()
    {
        // 1) User Input for Add method
        Console.WriteLine("Enter first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number (optional, press Enter to use default 10):");
        string input = Console.ReadLine();
        int num2;
        if (string.IsNullOrEmpty(input))
            num2 = 10;   // default value
        else
            num2 = Convert.ToInt32(input);

        int sum = Add(num1, num2);
        Console.WriteLine("Sum: " + sum);

        // 2) User Input for DisplayInfo method
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter age:");
        int age = Convert.ToInt32(Console.ReadLine());

        // Using Named Arguments
        DisplayInfo(age: age, name: name);
    }
}


