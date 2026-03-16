using System;
class HelloWorld {
  static double CalculateCircleArea(double r) {
      return Math.PI * Math.Pow(r, 2);
  }
  static void Main() {
    /*Problem 1: Creating a Function for Circle Area Calculation
    Problem Statement
    Write a function to calculate the area of a circle. 
    The function should accept one input parameter: 
    the radius of the circle. The program should prompt the user
    for this value, use the function to compute the area, and then 
    display the result.

    Formula: The area of a circle is given by π * r^2 where
    r is the radius of the circle. For Pi you will use the code Math.PI.*/
    
    Console.WriteLine("Enter circle's radius: ");
    double radius = double.Parse(Console.ReadLine());
    double area = CalculateCircleArea(radius);
    Console.WriteLine($"Circle's are is: {area}");
  }
}
