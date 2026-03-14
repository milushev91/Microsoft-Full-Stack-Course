// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int age;
        string membershipType;
        int feeAmount = 0;
        
        Console.WriteLine("Enter age:");
        age = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Select membership type: Basic or Premium:");
        membershipType = Console.ReadLine();
        
        if (age < 18)
        
        {
            if (membershipType == "Basic")
            
            {
                feeAmount = 15;
            }
            
            else if (membershipType == "Premium")
            
            {
                feeAmount = 25;
            }
        }
        
        else if (age <= 60)
        
        {
            if (membershipType == "Basic")
            
            {
                feeAmount = 30;
            }
            
            else if (membershipType == "Premium")
            
            {
                feeAmount = 50;
            }   
        }
        
        else
        
        {
            if (membershipType == "Basic")
            
            {
                feeAmount = 20;
            }
            
            else if (membershipType == "Premium")
            
            {
                feeAmount = 35;
            }            
        }
        
        Console.WriteLine(feeAmount);
    }
}
