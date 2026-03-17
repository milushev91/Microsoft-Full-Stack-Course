using System;

namespace HelloWorld
{
	public class Program
	{
	 
    static bool IsPositive(int number)
    
    {
      if (number > 0)
      
      {
        return true;
      }
      
      return false;
    }
		public static void Main(string[] args)
		{
		  int number = 3;
		  bool result = IsPositive(number);
		  
		  if (result)
		  
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
