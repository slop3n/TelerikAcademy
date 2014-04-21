//Write a program that finds the most frequent number in an array. Example:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MostFrequentNumber
{
    static void Main(string[] args)
    {
        int[] numbers = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int maxLength = 1;
        int length = 1;
        int startPosition = 0;
        Array.Sort(numbers);
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                length++;
                if (length > maxLength)
                {
                    maxLength = length;
                    startPosition = i - (length - 2);
                }

            }
            else
            {
                length = 1;
            }
        }
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(numbers[startPosition]);
        }
        Console.WriteLine();
    }
}
