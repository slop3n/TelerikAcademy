//Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArray
{
    static void Main(string[] args)
    {
        int[] numbers = {2,3,2,4,1,0,4,2};
        int currentMinIndex = 0;
        int temp;
        for (int i = 0; i < numbers.Length; i++)
        {
            currentMinIndex = i;
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] < numbers[currentMinIndex])
                {
                    currentMinIndex = j;
                }
            }
            if (currentMinIndex != i)
            {
                temp = numbers[ currentMinIndex];
                numbers[currentMinIndex] = numbers[i];
                numbers[i] = temp;
            }
        }
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}
