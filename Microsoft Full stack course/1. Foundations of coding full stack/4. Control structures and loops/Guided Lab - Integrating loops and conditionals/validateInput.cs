using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int input;
        
        do {
            Console.WriteLine("Enter a number between 1 and 10:");
            input = int.Parse(Console.ReadLine());
            
            if (input >= 1 && input <= 10 && input % 2 == 0) {
                Console.WriteLine("Valid input: " + input);
                break;
            } else {
                Console.WriteLine("Invalid input. Try again.");
            }
        } while (true);
    }   
}
