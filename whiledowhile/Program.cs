using System;

class WhileDoWhileInput
{
    static void Main(string[] args)
    {
        // WHILE LOOP with user input
        Console.Write("Enter a number for while loop: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n=== WHILE LOOP ===");
        int i = 1;
        while (i <= n1)
        {
            Console.WriteLine("Count: " + i);
            i++;
        }

        // DO-WHILE LOOP with user input
        Console.Write("\nEnter a number for do-while loop: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n=== DO-WHILE LOOP ===");
        int j = 1;
        do
        {
            Console.WriteLine("Count: " + j);
            j++;
        } while (j <= n2);
    }
}

