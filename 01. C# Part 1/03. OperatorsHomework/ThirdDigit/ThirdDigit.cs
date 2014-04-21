using System;

class ThirdDigit
{
    //Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.

    static void Main()
    {
        string number = Console.ReadLine();
        char digit = number[number.Length - 3];
        if (digit == '7' )
        {
            Console.WriteLine("The digit is 7");
        }
        else
        {
            Console.WriteLine("The digit is not 7");
        }
    }
}