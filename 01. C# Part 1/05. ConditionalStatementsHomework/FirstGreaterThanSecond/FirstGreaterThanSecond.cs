using System;

class FirstGreaterThanSecond
{

    // Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

    static void Main()
    {
        Console.WriteLine("Enter two numbers");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int temp;
        if (num1>num2)
        {
            temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
