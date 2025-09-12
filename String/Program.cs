using System;

class StringDemo
{
    static void Main(string[] args)
    {
        // User Input
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        Console.WriteLine("\n=== String Operations ===");

        // Original String
        Console.WriteLine("Original String: " + input);

        // String Length
        Console.WriteLine("Length of String: " + input.Length);

        // To Upper
        Console.WriteLine("Uppercase: " + input.ToUpper());

        // To Lower
        Console.WriteLine("Lowercase: " + input.ToLower());

        // Substring Example
        if (input.Length >= 3)
        {
            Console.WriteLine("First 3 characters: " + input.Substring(0, 3));
        }

        // Contains Example
        Console.WriteLine("Does it contain 'a'? : " + input.Contains("a"));

        // Replace Example
        Console.WriteLine("Replace 'a' with '@': " + input.Replace("a", "@"));
    }
}

