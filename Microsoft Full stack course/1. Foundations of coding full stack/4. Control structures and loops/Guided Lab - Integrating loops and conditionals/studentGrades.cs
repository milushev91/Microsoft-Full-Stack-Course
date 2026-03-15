using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] grades = {85, 92, 78, 64, 89};
        
        for (int i = 0; i < grades.Length; i++) {
            int grade = grades[i];
            string result;
            
            if (grade >= 65) {
                result = "Pass";
            } else {
                result = "Fail";
            }
            
            Console.WriteLine($"Student grade: {grade}. Result: {result}");
        }
    }   
}
