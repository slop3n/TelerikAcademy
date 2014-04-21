using System;

class OneToN
{

    //Write a program that prints all the numbers from 1 to N.

    static void Main()
    {
        Console.WriteLine("Enter a number");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
