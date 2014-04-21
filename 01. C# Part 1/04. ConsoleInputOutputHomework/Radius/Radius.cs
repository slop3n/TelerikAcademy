using System;

class Radius
{
    //Write a program that reads the radius r of a circle and prints its perimeter and area.

    static void Main()
    {
        double pi = Math.PI;
        Console.WriteLine("Enter radius for the circle: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of this circle is: {0}", pi*radius*pi);
        Console.WriteLine("The area of the circle is: {0}", pi*radius*radius);
    }
}
