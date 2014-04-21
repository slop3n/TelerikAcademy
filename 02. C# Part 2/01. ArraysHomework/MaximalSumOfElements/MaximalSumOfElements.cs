//Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSumOfElements
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of the array");
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K elements that have maximal sum");
        int k = int.Parse(Console.ReadLine());
        int[] numbers = new int[size];
        int[] maximalNumbers = new int[k];
        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numbers);
        Console.Write("The numbers that have maximal sum are ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(numbers[numbers.Length - i-1] + " ");
        }
        Console.WriteLine();

    }
}
