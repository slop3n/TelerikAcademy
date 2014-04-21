using System;

class PositiveOrNegative
{

    // Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        int counter = 0;
        if (num1 < 0)
        {
            counter++;
        }
        if (num2 < 0)
        {
            counter++;
        }
        if (num3 < 0)
        {
            counter++;
        }
        if (counter != 0 && counter !=2  )
        {
            Console.WriteLine("-");
        }
        else
	    {
            Console.WriteLine("+");
	    }
    }
}
