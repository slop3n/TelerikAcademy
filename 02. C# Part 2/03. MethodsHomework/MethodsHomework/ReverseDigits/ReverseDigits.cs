//Write a method that reverses the digits of given decimal number. Example: 256  652

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseDigits
{
    static void Main(string[] args)
    {
        int digit = int.Parse(Console.ReadLine());
        Console.WriteLine(ReverseNumber(digit));
    }
    static int ReverseNumber(int number)
    {
        int result = 0;
        while (number > 0)
        {
            result = result * 10 + number % 10;
            number /= 10;
        }
        return result;
    }
}