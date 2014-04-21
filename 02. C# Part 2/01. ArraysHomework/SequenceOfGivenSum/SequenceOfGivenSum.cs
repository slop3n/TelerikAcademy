//Write a program that finds in given array of integers a sequence of given sum S (if present).{4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequenceOfGivenSum
{
    static void Main(string[] args)
    {
        int[] numbers = { 4, 3, 1, 4, 2, 5, 8 };
        int givenSum = int.Parse(Console.ReadLine());
        int sum = 0;
        int start = 0;
        for (int i = 0; i < numbers.Length-1; i++)
        {
            sum += numbers[i];
            start = i;
            for (int j = i+1; j < numbers.Length; j++)
            {
                sum += numbers[j];
                if (sum == givenSum)
                {
                    for (int k = start; k <=j ; k++)
                    {
                        Console.Write(numbers[k] + " ");
                    }
                    return;
                }
            }
            sum = 0;
        }
    }
}
