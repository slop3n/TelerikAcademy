using System;

class GreatestCommonDivisor
{

    //Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int temp = 0;
        int remainder = 0;
        if (first < second)
        {
            first = temp;
            first = second;
            second = temp;
        }
       
        while (first % second != 0)
        {
            remainder = first % second;
            if (remainder == 0 )
            {
                Console.WriteLine("GCD is " + second);
            }
            else
	        {
                first = second;
                second = remainder;
	        }
        }

       
    }
}
