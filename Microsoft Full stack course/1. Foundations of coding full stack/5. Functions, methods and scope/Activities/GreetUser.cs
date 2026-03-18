using System;

namespace HelloWorld
{
	public class Program
	{
	  public static  void GreetUser(string name)
	  
	  {
	    Console.WriteLine("Hello " + name + "!");
	  }
		public static void Main(string[] args)
		{
			GreetUser("Alice");
		}
	}
}
