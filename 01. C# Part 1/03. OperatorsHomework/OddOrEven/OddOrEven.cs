using System;

class OddOrEven
{
    // Write an expression that checks if given integer is odd or even.

    static void Main()
    {
        Console.WriteLine("Please enter number");
        int number = int.Parse(Console.ReadLine());
        if (number % 2==0)
	    {
		    Console.WriteLine("The number is even");
	    }
        else
	    {
            Console.WriteLine("The number is odd");
	    }
    }
}

