using System;

class Person   // Class → blueprint
{
    // Properties / fields
    public string Name;  // Store person's name
    public int Age;      // Store person's age

    // Method to display greeting
    public void Greet()
    {
        Console.WriteLine($"Hello! My name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        // 1. Object creation from class
        Person person1 = new Person();

        // 2. Take user input for Name
        Console.Write("Enter Name: ");         // Display message
        person1.Name = Console.ReadLine();     // Read input and assign to Name

        // 3. Take user input for Age
        Console.Write("Enter Age: ");          // Display message
        person1.Age = Convert.ToInt32(Console.ReadLine()); // Read input and convert to int

        // 4. Call method to display greeting
        person1.Greet();  // Use the input data
    }
}

