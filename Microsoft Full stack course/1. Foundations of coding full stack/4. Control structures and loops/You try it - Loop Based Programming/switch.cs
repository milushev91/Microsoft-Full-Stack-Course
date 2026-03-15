// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       /*Create a program that schedules weekly tasks using a switch statement inside a for loop to assign a task for each day.

        Instructions:
        
        Define an array named weekDays containing the strings "Monday," "Tuesday," "Wednesday," "Thursday," "Friday."
        
        Use a for loop to iterate over each element in the array.
        
        Inside the loop, use a switch statement to assign a task to each day:
        
        If it's "Monday," print "Team Meeting."
        
        If it's "Tuesday," print "Code Review."
        
        If it's "Wednesday," print "Development."
        
        If it's "Thursday," print "Testing."
        
        If it's "Friday," print "Deployment."*/
        
        string[] weekDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
        
        for (int i = 0; i < weekDays.Length; i++)
        
        {
            switch (weekDays[i])
            
            {
                case "Monday":
                    Console.WriteLine("Team Meeting.");
                    break;
                case "Tuesday":
                    Console.WriteLine("Code Review.");
                    break;
                case "Wednesday":
                    Console.WriteLine("Development.");
                    break;
                case "Thursday":
                    Console.WriteLine("Testing.");
                    break;
                case "Friday":
                    Console.WriteLine("Deployment.");
                    break;
            }
        }
    }   
}
