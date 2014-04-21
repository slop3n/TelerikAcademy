// Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinarySearch
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of elements");
        int numberOfElements = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K");
        int k = int.Parse(Console.ReadLine());
        int[] elementsArray = new int[numberOfElements];
        for (int i = 0; i < elementsArray.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            elementsArray[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(elementsArray);
        if (k < elementsArray[0])
        {
            Console.WriteLine("K is smaller than all the elements");            
        }
        else
        {
            int a = Array.BinarySearch(elementsArray, k);
            if (a < 0)
            {
                Console.WriteLine(elementsArray[~a-1]);
            }
            else
            {
                Console.WriteLine(k);
            }
        }
    }
}