using System;

namespace HelloWorld
{
	public class Program
	{
	 
    static int CalculateSum(int a, int b)
    
    {
      return a + b;
    }
		public static void Main(string[] args)
		{
		  int sum = CalculateSum(5, 7);
		  Console.WriteLine("The sum is: " + sum);
		}
	}
}
