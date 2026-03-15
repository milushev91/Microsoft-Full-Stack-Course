// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       /*Step 2: Using a While Loop to Calculate Factorials
       Create a program that calculates the factorial of a given number using a while loop. The program should ask the user for an integer and then calculate its factorial.

        Instructions:
        
        Declare an integer variable number and set its value to 5.
        
        Use a while loop to calculate the factorial of the number.
        
        After each iteration, decrement the value of number.
        
        Print the factorial using Console.WriteLine().*/
        
        int number;
        int factorial = 0;
        
        do
        {
            Console.WriteLine("Enter a positive number: ");
            number = int.Parse(Console.ReadLine());
        } while (number < 0);
        
        factorial = number;
        
        if (number > 1) 
        
        {
            int counter = number - 1;
            
            while (counter > 1)
            
            {
                factorial *= counter;
                counter--;
            }
        }
        
        Console.WriteLine(factorial);
        
    }
}
