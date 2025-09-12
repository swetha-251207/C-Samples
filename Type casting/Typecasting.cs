using System;

class Program
{
    static void Main(string[] args)
    {
        // -------- Implicit Casting --------
        int myInt = 100;           // int (4 bytes)
        double myDouble = myInt;   // auto convert int → double (8 bytes)

        Console.WriteLine("Implicit Casting:");
        Console.WriteLine("int value: " + myInt);
        Console.WriteLine("double value: " + myDouble);

        // -------- Explicit Casting --------
        double pi = 3.14159;       // double
        int myNum = (int)pi;       // manually convert double → int

        Console.WriteLine("\nExplicit Casting:");
        Console.WriteLine("double value: " + pi);
        Console.WriteLine("int value: " + myNum);
    }
}