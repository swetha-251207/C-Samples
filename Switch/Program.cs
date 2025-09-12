using System;

class SwitchDemo
{
    static void Main(string[] args)
    {
        Console.Write("Enter a day number (1-7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n=== Day of the Week ===");

        switch (day)
        {
            case 1:
                Console.WriteLine("Sunday");
                break;
            case 2:
                Console.WriteLine("Monday");
                break;
            case 3:
                Console.WriteLine("Tuesday");
                break;
            case 4:
                Console.WriteLine("Wednesday");
                break;
            case 5:
                Console.WriteLine("Thursday");
                break;
            case 6:
                Console.WriteLine("Friday");
                break;
            case 7:
                Console.WriteLine("Saturday");
                break;
            default:
                Console.WriteLine("Invalid day number! Please enter 1 to 7.");
                break;
        }
    }
}

