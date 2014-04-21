//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. 
using System;

class CombinationsFromNumber
{
    static int N = int.Parse(Console.ReadLine());
    static int K = int.Parse(Console.ReadLine());

    static void Combinations(int[] array, int index, int currentNumber)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = currentNumber; i <= N; i++)
            {
                array[index] = i;
                Combinations(array, index + 1, i + 1);
            }
        }
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] array = new int[K];
        Combinations(array, 0, 1);
    }  
}
