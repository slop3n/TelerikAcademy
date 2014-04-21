//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrimeNumbers1To10Mil
{
    static void Main(string[] args)
    {
        Console.WriteLine("How much numbers do you want to be checked");
        int lenght = int.Parse(Console.ReadLine());
        long n = 10000000;
        bool[] e = new bool[n];
        for (int i = 2; i < n; i++)
        {
            e[i] = true; //set all numbers to true
        }
        for (int i = 2; i < n; i++)
        {
            if (e[i])
            {
                for (long j = 2; (j * i) < n; j++)
                {
                    e[j * i] = false;
                }
            }
        }
        for (int i = 0; i < lenght; i++)
        {
            if (e[i])
            {

                Console.WriteLine("The number {0} is prime", i);
            }
        }
    }

    public static int j { get; set; }
}