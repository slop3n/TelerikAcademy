//Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckNeighborElements
{
    public static int[] elementsArray = { 1, 2, 3, 6, 4, 8, 5 };
    static void Main(string[] args)
    {
        Console.Write("Enter index of the element you want to check: ");
        int numberToCheck = int.Parse(Console.ReadLine());
        Console.WriteLine("The element is bigger than its neighbors: " + Checker(numberToCheck));
    }

    static bool Checker(int index)
    {
        if (index == 0 && elementsArray[index] > elementsArray[index + 1])
        {
            return true;
        }
        if (index > 0 && index < elementsArray.Length)
        {
            if (index < elementsArray.Length - 2 && elementsArray[index] > elementsArray[index - 1] && elementsArray[index] > elementsArray[index + 1])
            {
                return true;
            }
            else if (index == (elementsArray.Length - 1) && elementsArray[index] > elementsArray[index-1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}