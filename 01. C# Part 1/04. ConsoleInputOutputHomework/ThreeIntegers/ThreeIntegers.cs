using System;

class ThreeIntegers
{

    // Write a program that reads 3 integer numbers from the console and prints their sum.

    static void Main()
    {
        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("The sum of the numbers is {0}", num1+num2+num3);
    }
}

