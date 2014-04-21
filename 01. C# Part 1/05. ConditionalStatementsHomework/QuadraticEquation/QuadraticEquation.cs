using System;

class QuadraticEquation
{

    //Write a program that enters the coefficients a, b and c of a quadratic equation: a*x2 + b*x + c = 0, and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.

    static void Main()
    {
        Console.WriteLine("Enter first number");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number");
        double c = double.Parse(Console.ReadLine());
        double D = Math.Sqrt(b * b - (4 * a * c));
        double firstX = (-b + D) / (2 * a);
        double secondX = (-b - D) / (2 * a);
        if ((b * b - (4 * a * c)) < 0)
        {
            Console.WriteLine("There are no real roots that solve this equation");
        }
        else if (firstX!=secondX)
        {
            Console.WriteLine("The first real root of X is: {0}", firstX);
            Console.WriteLine("The second real root of X is: {0}", secondX);
        }
        else if (firstX==secondX)
        {
            Console.WriteLine("The only real root of X is: {0}", firstX);
        }

    }
}
