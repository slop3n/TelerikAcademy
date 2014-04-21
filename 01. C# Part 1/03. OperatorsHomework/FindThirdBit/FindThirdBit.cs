using System;

class FindThirdBit
{
    // Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
    
    static void Main()
    {
        Console.WriteLine("Please enter number:");
        int num = int.Parse(Console.ReadLine());
        int p = 2;
        int mask = 1 << p;
        int numAndMask = num & mask;
        int num2 = numAndMask >> p;
        Console.WriteLine(num2);
    }
}

