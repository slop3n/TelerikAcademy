using System;

class PrimeNumbers
{

    // Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
    // 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97,

    static void Main()
    {
        Console.WriteLine("Please enter a number");
        int num = int.Parse(Console.ReadLine());
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0)
            {
                Console.WriteLine("number is not prime");
                break;
            }
            else
            {
                Console.WriteLine("number is prime");
                break;
            }
        }
    }
}

