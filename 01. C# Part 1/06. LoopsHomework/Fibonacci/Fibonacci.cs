using System;

class Fibonacci
{

    //Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int a = 0;
        int b = 1;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum = a;
            a = b;
            b = b + sum;
            int totalsum = b;
        }

    }
}
