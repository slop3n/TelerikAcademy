//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 4, 4, 4, 4, 4, 4, 4, 1 };
        int maxLength = 1;
        int length = 1;
        int startPosition = 0;
        for (int i = 0; i < numbers.Length-1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                length++;
                if (length > maxLength)
                {
                    maxLength = length;
                    startPosition = i - (length - 2);
                }
            }
            else
            {
                length = 1;
            }
        }
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(numbers[startPosition]);
        }
        Console.WriteLine();
    }
}