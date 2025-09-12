using System;

class BreakContinueDemo
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n=== Using break ===");
        for (int i = 1; i <= n; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Break at i = " + i);
                break;  // exit the loop completely
            }
            Console.WriteLine("i = " + i);
        }

        Console.WriteLine("\n=== Using continue ===");
        for (int i = 1; i <= n; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Skip i = " + i);
                continue;  // skip this iteration
            }
            Console.WriteLine("i = " + i);
        }
    }
}

