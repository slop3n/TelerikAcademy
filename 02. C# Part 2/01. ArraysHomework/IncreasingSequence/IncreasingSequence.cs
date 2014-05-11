//Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingSequence
{
    class IncreasingSequence
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 1, 2, 3, 4, 3, 2, 2, 2, 2, 4, 4, 4, 4, 4, 4, 4, 1 };
            int maxLength = 1;
            int length = 1;
            int startPosition = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] + 1 == numbers[i + 1])
                {
                    length++;
                    if (length > maxLength)
                    {
                        maxLength = length;
                        startPosition = i - length + 2;
                    }
                }
                else
                {
                    length = 1;
                }
            }
            for (int i = 0; i < maxLength; i++)
            {
                Console.WriteLine(numbers[startPosition] + i);
            }
        }
    }
}
