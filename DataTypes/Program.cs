using System;

class Program
{
    static void Main(string[] args)
    {
        // Integer type
        int myInt = 25;
        Console.WriteLine("Integer: " + myInt);

        // Floating point types
        float myFloat = 3.14f;       // f suffix must use for float
        double myDouble = 9.876;
        Console.WriteLine("Float: " + myFloat);
        Console.WriteLine("Double: " + myDouble);

        // Character type
        char myChar = 'A';
        Console.WriteLine("Char: " + myChar);

        // String type
        string myString = "Hello World";
        Console.WriteLine("String: " + myString);

        // Boolean type
        bool isTrue = true;
        Console.WriteLine("Boolean: " + isTrue);

        // Decimal type
        decimal myDecimal = 100.50m;   // m suffix for decimal
        Console.WriteLine("Decimal: " + myDecimal);

        // Object type
        object myObj = "I am object";
        Console.WriteLine("Object: " + myObj);
    }
}
