// Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class QuickSort
{
    
    static public int partition(int[] numbers, int left, int right)
    {
        int pivot = numbers[left];
        while (true)
        {
            while (numbers[left] < pivot)
            {
                left++;
            }
            while (numbers[right] > pivot)
            {
                right--;
            }
            if (left < right)
            {
                int temp = numbers[right];
                numbers[right] = numbers[left];
                numbers[left] = temp;
            }
            else
            {
                return right;
            }
        }
    }

    static public void quicksort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = partition(arr, left, right);
            if (pivot > 1)
            {
                quicksort(arr, left, pivot - 1);
            }
            if (pivot + 1 < right)
            {
                quicksort(arr, pivot + 1, right);
            }
        }
    }

    static void Main(string[] args)
    {
        int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
        int len = numbers.Length;
        Console.WriteLine("QuickSort By Recursive Method");
        quicksort(numbers, 0, len - 1);
        for (int i = 0; i < 9; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine();
    }
}