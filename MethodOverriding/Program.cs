using System;

class Animal
{
    // Base class method with virtual keyword
    public virtual void Sound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    // Overriding the base class method
    public override void Sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    // Overriding the base class method
    public override void Sound()
    {
        Console.WriteLine("Cat meows");
    }
}

class Program
{
    static void Main()
    {
        // Base class reference, base class object
        Animal a1 = new Animal();
        a1.Sound();  

        // Base class reference, Dog object
        Animal a2 = new Dog();
        a2.Sound();  

        // Base class reference, Cat object
        Animal a3 = new Cat();
        a3.Sound(); 
    }
}

