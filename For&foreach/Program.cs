using System;

class LoopDemo
{
    static void Main(string[] args)
    {
        // FOR LOOP (counting backwards)
        Console.WriteLine("=== FOR LOOP (Backward Counting) ===");
        Console.Write("Enter a number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = n; i >= 1; i--)   // Decrementing loop
        {
            Console.WriteLine("Count: " + i);
        }

        // FOREACH LOOP with array
        Console.WriteLine("\n=== FOREACH LOOP ===");
        string[] fruits = { "Apple", "Banana", "Orange", "Mango" };

        foreach (string fruit in fruits)
        {
            Console.WriteLine("Fruit: " + fruit);
        }
    }
}

