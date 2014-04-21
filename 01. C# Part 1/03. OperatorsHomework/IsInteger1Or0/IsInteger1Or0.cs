using System;

class IsInteger1Or0
{
    // Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.

    static void Main()
    {
        Console.WriteLine("Please enter number");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position of the bit you want to check");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int maskAndNum = mask & num;
        maskAndNum = maskAndNum >> p;
        if (maskAndNum == 1)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}