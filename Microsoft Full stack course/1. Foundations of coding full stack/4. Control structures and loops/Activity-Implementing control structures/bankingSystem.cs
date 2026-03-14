// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double interestRate = 0;
        int monthlyFee = 0;
        string accountType;
        
        Console.WriteLine("Select account type: Savings, Checking, Bussiness:");
        accountType = Console.ReadLine();
        
        switch (accountType)
        
        {
            case "Savings":
                interestRate = 0.2;
                break;
            case "Checking":
                monthlyFee = 10;
                break;
            case "Bussiness":
                interestRate = 0.1;
                monthlyFee = 20;
                break;
            default:
                Console.WriteLine("Invalid account Type!");
                break;
        }
        
        Console.WriteLine(interestRate);
        Console.WriteLine(monthlyFee);
    }
}
