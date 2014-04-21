using System;

class Program
{
    // Write an expression that checks if given point (x,  y) is within a circle K(O, 5).

    static void Main(string[] args)
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        double radius = 5;
        if (radius*radius >= (x * x) + (y * y))
        {
            Console.WriteLine("its inside the circle");
        }
        else
	    {
            Console.WriteLine("its outside the circle");
	    }
    }
}

