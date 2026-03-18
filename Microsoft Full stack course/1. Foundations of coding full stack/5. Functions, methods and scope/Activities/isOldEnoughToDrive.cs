using System;

namespace HelloWorld
{
	public class Program
	{
	  public static bool IsOldEnoughToDrive(int age)
	  
	  {
	    if (age >= 18)
	    
	    {
	      return true;
	    }
	    
	    return false;
	  }
	  
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter your age: ");
			
			int age = int.Parse(Console.ReadLine());
			bool canDrive = IsOldEnoughToDrive(age);
			
			if (canDrive)
			
			{
			  Console.WriteLine("You are old enougth to drive.");
			}
			
			else 
			
			{
			  Console.WriteLine("You are not old enougth to drive.");
			}
			
		}
	}
}
