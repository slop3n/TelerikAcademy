using System;

class GreaterNumber
{

    // Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        int c = (a + b + Math.Abs(a - b)) / 2;
        Console.WriteLine("The larger number is: {0}",c);
    }
}
