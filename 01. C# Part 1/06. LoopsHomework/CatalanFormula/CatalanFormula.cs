using System;

class CatalanFormula
{

    //Write a program to calculate the Nth Catalan number by given N.

    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double nominator = n * 2;
        double denominator = n + 1;
        double n1 = n;
        double factorial1 = 1;
        double factorial2 = 1;
        double factorial3 = 1;
        while (nominator > 0)
        {
            factorial1 = factorial1 * nominator;
            nominator--;
        }
        while (denominator > 0)
        {
            factorial2 = factorial2 * denominator;
            denominator--;

        }
        while (n1>0)
        {
            factorial3 = factorial3 * n1;
            n1--;
        }
        Console.WriteLine(factorial1/(factorial2*factorial3));
    }
}