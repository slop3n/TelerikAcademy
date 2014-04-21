//Write a program to convert decimal numbers to their binary representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinary
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string result = ConvertDecimalToBinary(int.Parse(Console.ReadLine()));
        Console.WriteLine("The decimal representation of this number is: " + result);
    }

    static string ConvertDecimalToBinary(int decimalNum)
    {
        int remainder;
        string result = "";
        while (decimalNum > 0)
        {
            remainder = decimalNum % 2;
            decimalNum /= 2;
            result = remainder.ToString() + result;            
        }
        return result;
    }
}