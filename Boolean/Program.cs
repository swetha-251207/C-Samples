using System;

class BooleanExample
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        // Boolean condition
        bool isAdult = age >= 18;

        Console.WriteLine("\n=== Boolean Check ===");
        Console.WriteLine("Age entered: " + age);
        Console.WriteLine("Is Adult? " + isAdult);

        // Using Boolean in if-else
        if (isAdult)
        {
            Console.WriteLine("You are eligible to vote.");
        }
        else
        {
            Console.WriteLine("You are NOT eligible to vote.");
        }
    }
}

