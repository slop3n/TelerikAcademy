using System;

class CompareNumbers
{
    // Write a program that safely compares floating-point numbers with precision of 0.000001. Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true

    static void Main()
    {
        Console.WriteLine("Please enter first number");
        float num1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number");
        float num2 = float.Parse(Console.ReadLine());
        Console.WriteLine(num1 == num2);
    }
}
