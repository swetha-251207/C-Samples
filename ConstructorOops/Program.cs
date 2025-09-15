using System;

class Person
{
    // Private fields
    private string Name;
    private int Age;

    // Parameterized Constructor → takes input during object creation
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Method to display data
    public void Greet()
    {
        Console.WriteLine($"Hello! My name is {Name} and I am {Age} years old.");
    }
}

class Program
{
    static void Main()
    {
        // 1. Take user input
        Console.Write("Enter Name: ");
        string inputName = Console.ReadLine();

        Console.Write("Enter Age: ");
        int inputAge = Convert.ToInt32(Console.ReadLine());

        // 2. Object creation with constructor → input values pass pannuvom
        Person person1 = new Person(inputName, inputAge);

        // 3. Call method to display data
        person1.Greet();
    }
}

