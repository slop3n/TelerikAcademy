//Write a program to convert decimal numbers to their hexadecimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHexadecimal
{

    static void printNumber(List<int> arr)
    {
        foreach (var num in arr)
        {
            if (num < 10)
            {
                Console.Write((char)('0' + num));
            }
            else
            {
                Console.Write((char)('A' + num % 10));
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        List<int> test = new List<int>();
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        do
        {
            test.Add(number % 16);
            number /= 16;
        }
        while (number != 0);
        test.Reverse();
        Console.Write("The desired number in hexadecimal is: ");
        printNumber(test);
    }
}