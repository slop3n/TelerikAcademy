using System;

class Program
{
    //Write an expression that calculates rectangle’s area by given width and height.

    static void Main()
    {
        Console.Write("Please enter width: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Please enter height: ");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("This rectangle's area is: {0}", width * height);
    }
}

