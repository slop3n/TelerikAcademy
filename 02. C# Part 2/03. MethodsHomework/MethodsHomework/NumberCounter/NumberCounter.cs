//Writ,e a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberCounter
{
    public static int[] numbersArray = { 1, 2, 3, 2, 2, 2 };

    static void Main(string[] args)
    {
        Console.WriteLine("Enter number you want to check");
        int numberToCheck = int.Parse(Console.ReadLine());
        int checkedNumber = Counter(numberToCheck);
        Console.WriteLine("The number {0} is met {1} times", numberToCheck, checkedNumber);
    }

    static int Counter(int number)
    {
        int counter = 0;
        for (int i = 0; i < numbersArray.Length; i++)
        {
            if (numbersArray[i] == number)
            {
                counter++;
            }
        }
        return counter;
    }
}