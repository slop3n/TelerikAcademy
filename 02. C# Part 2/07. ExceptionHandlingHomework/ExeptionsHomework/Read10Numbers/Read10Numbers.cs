//Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Read10Numbers
{
    static void ReadNumber(int start, int end)
    {
        int[] allNumbers = new int[10];
        for (int i = 0; i < 10; i++)
        {
            try
            {
                Console.Write("Enter number with smaller value than the previous: ");
                allNumbers[i] = int.Parse(Console.ReadLine());
                if (allNumbers[i] < start || allNumbers[i] > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid integer number!");
                break;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number should be greater than the previous!");
                break;
            }
            start = allNumbers[i];
        }
    }
    static void Main()
    {
        int start = 1;
        int end = 100;
        ReadNumber(start, end);
    }
}