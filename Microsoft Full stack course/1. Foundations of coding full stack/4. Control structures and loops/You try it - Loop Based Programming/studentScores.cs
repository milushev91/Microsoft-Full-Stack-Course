using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*Write a program that uses a for loop with an if-else structure to check if each student's score meets the passing criteria. A student passes if their score is 50 or above.
        
        Instructions:
        
        Define an array named studentScores containing the integers 45, 60, 72, 38, and 55.
        
        Use a for loop to iterate over each element in the array.
        
        Inside the loop, use an if-else statement to check if the score is 50 or above.
        
        Print "Pass" if the score is 50 or above; otherwise, print "Fail."*/
        
        int[] studentScores = {45, 60, 72, 38, 55};
        
        for (int i = 0; i < studentScores.Length; i++)
        
        {
            if (studentScores[i] >= 50)
            
            {
                Console.WriteLine("Pass");
            }
            
            else 
            
            {
                Console.WriteLine("Fail");
            }
        }
    }   
}
