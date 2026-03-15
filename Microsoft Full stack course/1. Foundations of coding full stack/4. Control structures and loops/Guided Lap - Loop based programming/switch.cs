using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       string[] weather = {"Sunny", "Rainy", "Cloudy", "other"};
       
       for (int i = 0; i < weather.Length; i++)
       
       {
           switch (weather[i])
           
           {
                case "Sunny":
                    Console.WriteLine("It's sunny, wear sunglasses!");
                    break;
                case "Rainy":
                    Console.WriteLine("It's rainy, take an umbrella.");
                    break;
                case "Cloudy":
                    Console.WriteLine("It's cloudy, take a jacket.");
                    break;
                default:
                    Console.WriteLine("Unknown weather condition.");
                    break;
                
           }
       }
    }
}
