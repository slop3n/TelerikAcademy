//Write a program to convert binary numbers to their decimal representation.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter binary number: ");
        int result = ConverBinaryToDecimal(Console.ReadLine());
        Console.WriteLine("The number is: " + result);
    }

    static int ConverBinaryToDecimal(string binaryNum)
    {
        int decimalNum = 0;
        for (int i = 0; i < binaryNum.Length; i++)
        {
            if (binaryNum[binaryNum.Length - i - 1] == '0')
            {
                continue;
            }
            else
            {
                decimalNum += (int)Math.Pow(2, i);
            }
        }
        return decimalNum;
    }
}