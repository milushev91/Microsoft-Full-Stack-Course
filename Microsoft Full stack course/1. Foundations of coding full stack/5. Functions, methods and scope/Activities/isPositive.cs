using System;

namespace HelloWorld
{
	public class Program
	{
	  public static bool IsPositive(int num)
	  
	  {
	    if (num > 0)
	    
	    {
	      return true;
	    }
	    
	    return false;
	  }
	  
		public static void Main(string[] args)
		{
			int num = 5;
			bool IsPositiveResult = IsPositive(num);
			
			if (IsPositiveResult)
			
			{
			  Console.WriteLine("The number is positive.");
			} 
			
			else 
			
			{
			  Console.WriteLine("The number is not positive.");
			}
			
		}
	}
}
