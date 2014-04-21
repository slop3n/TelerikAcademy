//Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static int[] elementsArray = { 1, 2, 6, 9, 7, 9 };

    static void Main(string[] args)
    {
        for (int i = 0; i < elementsArray.Length; i++)
        {
            if (Checker(i))
            {
                Console.WriteLine("The element on position {0} is bigger than its neighbors",i);
                break;
            }
            else if(i == elementsArray.Length-1)
            {
                Console.WriteLine("No such element exists");
            }
        }
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
            else if (index == (elementsArray.Length - 1) && elementsArray[index] > elementsArray[index - 1])
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