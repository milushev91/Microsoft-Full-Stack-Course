using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       /*Step 1: Using a For Loop to Calculate Total Scores
       You are developing a program for a quiz system to calculate the total score of a student based on individual quiz scores. The scores are stored in an array, and you need to use a for loop to sum them up.

        Instructions:
        
        Define an array named scores containing the integers 85, 90, 78, 92, and 88.
        
        Use a for loop to iterate over each element in the array and calculate the total score.
        
        Print the total score using Console.WriteLine().*/
        
        int[] scores = {85, 90, 78, 92, 88};
        
        int sum = 0;
        
        for (int i = 0; i < scores.Length; i++)
        
        {
            sum += scores[i];
        }
        
        Console.WriteLine(sum);
      
    }
}
