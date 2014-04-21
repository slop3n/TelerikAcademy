using System;

class QuadraticEquation
{

    //Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

    static void Main()
    
{
        Console.WriteLine("Enter first number");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        double c = double.Parse(Console.ReadLine());
        double D = Math.Sqrt(b * b - 4 * a * c);
        double firstX = (-b + D) / (2 * a);
        double secondX = (-b - D) / (2 * a);
        Console.WriteLine("The first possible value of X is: {0}", firstX);
        Console.WriteLine("The second possible value of X is: {0}", secondX);
    }
}
