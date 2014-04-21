using System;

class DivideBy5And7
{
    // Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

    static void Main()
    {
        Console.WriteLine("Please enter number");
        int number = int.Parse(Console.ReadLine());
        if (number % 5 ==0 && number % 7 == 0)
        {
            Console.WriteLine("The number can be divided by 5 and 7 without remainder");
        }
        else
        {
            Console.WriteLine("The number can't be divided by 5 and 7 without remainder");
        }
    }
}
