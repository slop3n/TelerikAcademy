//Write a program that finds the sequence of maximal sum in given array. Example:{2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceOfMaximalSum
{
    static void Main(string[] args)
    {
        int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int sum = 0;
        int maxSum = 0;
        int firstIndex = 0;
        int lastIndex = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
            if (sum > 0 && sum > maxSum)
            {
                maxSum = sum;
                lastIndex = i;                
            }
            else if (sum < 0)
            {
                sum = 0;
                lastIndex = 0;
                firstIndex = i + 1;
            }
        }
        Console.WriteLine("The sequence with maximal sum is ");
        for (int i = firstIndex ; i <= lastIndex; i++)
        {
            Console.Write(numbers[i]);
            if (i < lastIndex)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
