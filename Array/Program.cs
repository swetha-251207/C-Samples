using System;

class ArrayDemo
{
    static void Main(string[] args)
    {
        // Declare and initialize array
        string[] fruits = { "Apple", "Banana", "Orange", "Mango" };

        // Accessing array elements
        Console.WriteLine("=== Access Array Elements ===");
        Console.WriteLine("First fruit: " + fruits[0]);
        Console.WriteLine("Second fruit: " + fruits[1]);

        // Change array element
        Console.WriteLine("\n=== Change Array Element ===");
        Console.WriteLine("Before change: " + fruits[2]);
        fruits[2] = "Grapes"; // change Orange to Grapes
        Console.WriteLine("After change: " + fruits[2]);

        // Array length
        Console.WriteLine("\n=== Array Length ===");
        Console.WriteLine("Total number of fruits: " + fruits.Length);

        // Loop through array
        Console.WriteLine("\n=== Looping Array with for ===");
        for (int i = 0; i < fruits.Length; i++)
        {
            Console.WriteLine("Fruit " + (i + 1) + ": " + fruits[i]);
        }

        Console.WriteLine("\n=== Looping Array with foreach ===");
        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }
    }
}

