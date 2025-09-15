using System;

class BankAccount
{
    // 1. Private fields → hide sensitive data
    private string accountHolder;
    private double balance;

    // 2. Public method → Set account holder name safely
    public void SetAccountHolder(string name)
    {
        accountHolder = name;
    }

    // 3. Public method → Set balance safely
    public void SetBalance(double amount)
    {
        if (amount >= 0)        // validation
            balance = amount;
        else
            Console.WriteLine("Invalid balance");
    }

    // 4. Public method → Display account info
    public void DisplayAccount()
    {
        Console.WriteLine($"Account Holder: {accountHolder}, Balance: {balance}");
    }
}

class Program
{
    static void Main()
    {
        // 5. Object creation from class
        BankAccount acc1 = new BankAccount();

        // 6. Take input and set values using methods
        Console.Write("Enter Account Holder Name: ");
        string name = Console.ReadLine();
        acc1.SetAccountHolder(name);

        Console.Write("Enter Balance: ");
        double bal = Convert.ToDouble(Console.ReadLine());
        acc1.SetBalance(bal);

        // 7. Display account info
        acc1.DisplayAccount();

        // 8. Try direct access (will fail)
        // acc1.balance = 10000; // ❌ Error: balance is private
    }
}
