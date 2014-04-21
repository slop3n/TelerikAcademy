using System;

class TrapezoidArea
// Write an expression that calculates trapezoid's area by given sides a and b and height h.

{
    static void Main()
    {
        Console.Write("Enter value for first base: ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter value for second base: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter value for height: ");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("The trapezoid's area is: {0}", ((side1+side2)/2) * height);
    }
}
