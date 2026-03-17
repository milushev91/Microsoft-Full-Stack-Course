using System;

namespace HelloWorld
{
	public class Program
	{
	 
    static bool IsOldEnoughToDrive(int age)
    
    {
      if (age >= 18)
      
      {
        return true;
      }
      
      return false;
    }
		public static void Main(string[] args)
		{
		  Console.WriteLine("Enter Your age: ");
		  int age = int.Parse(Console.ReadLine());
		  bool canDrive = IsOldEnoughToDrive(age);
		  
		  if (canDrive)
		  
		  {
		    Console.WriteLine("You are old enough to drive.");
		  }
		  
		  else 
		  
		  {
		    Console.WriteLine("You are not old enough to drive.");
		  }
		}
	}
}
