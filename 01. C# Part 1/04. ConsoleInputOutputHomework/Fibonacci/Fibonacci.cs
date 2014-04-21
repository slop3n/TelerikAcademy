using System;
using System.Numerics;

class Fibonacci
{

    // Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

    static void Main()
    {
        BigInteger first = 0;
        BigInteger second = 1;
        BigInteger next = 0;
        for (int i = 0; i < 99; i++)
        {
            next = first + second;
            first = second;
            second = next;
            Console.WriteLine(next);
        }
    }
}
