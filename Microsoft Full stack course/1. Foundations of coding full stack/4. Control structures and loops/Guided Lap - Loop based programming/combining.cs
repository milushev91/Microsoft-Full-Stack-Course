using System;
					
public class Program
{
	public static void Main()
	{
		int[] numbers = {1, 2, 3, 4, 5};
		
		for (int i = 0; i < numbers.Length; i++)
		
		{
			if (numbers[i] % 2 == 0)
			
			{
				Console.WriteLine(numbers[i] + " is even");
			}
			else
			{
				Console.WriteLine(numbers[i] + " is odd");
			}
		}	
	}
}
