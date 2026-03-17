using System;

namespace HelloWorld
{
	public class Program
	{
	  public static int CalcRectBoxVol(int l, int w, int h)
	  
	  {
	    return l * w * h;
	  }
	 
		public static void Main(string[] args)
		
		{
		  Console.WriteLine("Enter length: ");
      int length = int.Parse(Console.ReadLine());
      
		  Console.WriteLine("Enter width: ");
      int width = int.Parse(Console.ReadLine());
      
		  Console.WriteLine("Enter height: ");
      int height = int.Parse(Console.ReadLine());
      
      int volume = CalcRectBoxVol(length, width, height);
      Console.WriteLine(volume);
		}
	}
}
