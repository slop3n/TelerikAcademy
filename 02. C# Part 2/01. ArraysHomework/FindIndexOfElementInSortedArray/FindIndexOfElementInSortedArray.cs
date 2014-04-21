//Write a program that finds the index of given element in a sorted array of integers by using the binary search algorithm 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FindIndexOfElementInSortedArray
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        int element = int.Parse(Console.ReadLine());
        int max = numbers.Length - 1;
        int min = 0;
        while (max >= min)
        {
            int middle = (min + max) / 2;
            if (numbers[middle] == element)
            {
                Console.WriteLine(middle);
                break;
            }
            else if (numbers[middle] < element)
            {
                min = middle + 1;
            }
            else
            {
                max = middle - 1;
            }
        }
    }
}
