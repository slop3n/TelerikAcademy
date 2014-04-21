using System;

class MinAndMaxNumber
{

    //Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

    static void Main()
    {
        Console.Write("Choose how many number you would lke to enter ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int min= int.MaxValue;
        int max=0;
        for (int i = 0; i < n; i++)
        {
            int o = int.Parse(Console.ReadLine());
            if (min > o)
            {
                min = o;
            }
            if (o > max)
            {
                max = o;
            }  
        }
        Console.WriteLine("The minimal number is " + min);
        Console.WriteLine("The maximal number is " + max);
    }
}
