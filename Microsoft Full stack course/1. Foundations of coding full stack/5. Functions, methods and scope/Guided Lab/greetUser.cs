using System;

namespace HelloWorld
{
	public class Program
	{
	 
	  public void GreetUser(string name) 
	  
	  {
	    Console.WriteLine("Hello, " + name + "!");
	  }
		public static void Main(string[] args)
		{
		  Program program = new Program();
		  program.GreetUser("Alice");
		}
	}
}
