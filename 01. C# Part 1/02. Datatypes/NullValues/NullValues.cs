using System;

class Program
{
    // Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result

    static void Main()
    {
        int? num1 = null;
        double? num2 = null;
        Console.WriteLine(num1 + 5);
        Console.WriteLine(num2);
        int? num3 = int.parse(console.readline());
        Console.WriteLine(num3 + 5);
    }
}
