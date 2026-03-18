using System;

namespace HelloWorld
{
	public class Program
	{
	  public static int CalculateSum(int num1, int num2)
	  
	  {
	    return num1 + num2;
	  }
		public static void Main(string[] args)
		{
			int sum = CalculateSum(5, 7);
			Console.WriteLine("The sum is: " + sum);
		}
	}
}
