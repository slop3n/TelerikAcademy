using System;

class CalculateSum
{

    // Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN
    static decimal Factorial(decimal number)
    {
        decimal factorialN = 1;
        for (int j = 1; j <= number; j++)
        {
            factorialN = factorialN * j;
        }
        return factorialN;
    }

    static void Main()
    {
        decimal x = decimal.Parse(Console.ReadLine());
        decimal n = decimal.Parse(Console.ReadLine());
        decimal sum = 1.0m;
        for (int i = 1; i <= n; i++)
        {
            decimal denominator = x * i;
            sum += Factorial(i) / denominator;
        }
        Console.WriteLine(sum);
    }
}