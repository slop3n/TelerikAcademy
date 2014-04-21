//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).
using System;
using System.Collections.Generic;

class TwoDifferentBaseSystems
{
    static void printNumber(List<int> arr)
    {
        foreach (var num in arr)
        {
            if (num < 6)
            {
                Console.Write((char)('0' + num));
            }
            else
            {
                Console.Write((char)('A' + num % 6));
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        List<int> test = new List<int>();
        Console.WriteLine("Enter number in base 6 numeral system");
        int number = int.Parse(Console.ReadLine());
        do
        {
            test.Add(number % 12);
            number /= 12;
        }
        while (number != 0);
        test.Reverse();
        Console.WriteLine("The number in base 12 numeral system is" );
        printNumber(test);
    }
}