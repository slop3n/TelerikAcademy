using System;

class TwoPositiveIntegers
{
    // Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.

    static void Main()
    {
        uint a = uint.Parse(Console.ReadLine());
        uint b = uint.Parse(Console.ReadLine());
        int counter = 0;
        for (uint i = a; i <= b; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}
