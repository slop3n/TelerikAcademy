using System;

class ExhangeValues
{
    // Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.

    static void Main()
    {
        int num1 = 5;
        int num2 = 10;
        Console.WriteLine("First number is {0}", num1);
        Console.WriteLine("Second number is {0}", num2);
        int temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine("After exchanging values:");
        Console.WriteLine("First number is {0}", num1);
        Console.WriteLine("Second number is {0}", num2);
    }
}
