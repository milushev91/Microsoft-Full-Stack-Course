using System;
class HelloWorld {
    /*Problem 2: Creating a Function for Trapezoid Area Calculation
    Problem Statement
    Write a function to calculate the area of a trapezoid.
    The function should accept three input parameters: 
    the length of the two parallel sides (a and b) and the height.
    The program should prompt the user for these values, use the
    function to compute the area, and then display the result.

    Formula: The area of a trapezoid is given by (a + b) / 2 * height.*/
    
  static double CalculateTrapezoidArea(double a, double b, double h) {
      return (a + b) / 2 * h;
  }
  static void Main() {
    Console.WriteLine("Enter Trapezoid's first side: ");
    double sideA = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Trapezoid's second side: ");
    double sideB = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter Trapezoid's height: ");
    double height = Convert.ToDouble(Console.ReadLine());
    
    double area = CalculateTrapezoidArea(sideA, sideB, height);
    Console.WriteLine($"Trapezoid's area is: {area}.");
    
    
  }
}
