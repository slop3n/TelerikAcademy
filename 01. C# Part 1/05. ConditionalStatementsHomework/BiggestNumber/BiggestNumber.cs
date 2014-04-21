using System;

class BiggestNumber
{

    //Write a program that finds the biggest of three integers using nested if statements.

    static void Main()
    {
        Console.WriteLine("Enter three numbers");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        if (a>b && a>c)
        {
            Console.WriteLine("The biggest number is " + a);
        }
        else if (b>a&&b>c)
        {
            Console.WriteLine("The biggest number is " + b);
        }
        else if (c>a&&c>b)
        {
            Console.WriteLine("The biggest number is " + c);
        }
    }
}
