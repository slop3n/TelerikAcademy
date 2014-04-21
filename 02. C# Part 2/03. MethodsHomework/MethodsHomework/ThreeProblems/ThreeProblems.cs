//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods. Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ThreeProblems
{
    static void Main(string[] args)
    {
        Menu();
    }

    static void EnterNumberForReversing()
    {
        Console.Write("Enter number you want to reverse: ");
        int numberToReverse = int.Parse(Console.ReadLine());
        Console.WriteLine("That number reversed is: " + ReverseNumber(numberToReverse));
    }

    static void EnterNumbersForAverage()
    {
        Console.Write("Enter number of numbers to find the average of: ");
        int arraySize = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[arraySize];
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write("Enter number {0}: ", i+1);
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("The average of those numbers is: ");
        Console.WriteLine(Average(arrayOfNumbers));
    }

    static void EnterNumbersForEquation()
    {
        Console.Write("Enter number for A: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter number for B: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("The solution for X is: " + LinearEquation(a,b));
    }

    static int ReverseNumber(int number)
    {
        int result = 0;
        while (number > 0)
        {
            result = result * 10 + number % 10;
            number /= 10;
        }
        return result;
    }

    static double Average(int[] array)
    {
        double average = 0;
        for (int i = 0; i < array.Length; i++)
        {
            average += array[i];
        }
        average = average / array.Length;
        return average;
    }

    static double LinearEquation(double numberA, double numberB)
    {
        double numberX = (numberB / numberA) * -1;
        return numberX;
    }

    static void Menu()
    {
        Console.WriteLine("Choose the task you want to do by entering a number [1:3]");
        Console.WriteLine("1: Reverse the digits of a number");
        Console.WriteLine("2: Calculate the average of sequence of integers");
        Console.WriteLine("3: Solve a linear equation a * x + b = 0");
        int choiceOfUser = int.Parse(Console.ReadLine());
        if (choiceOfUser == 1 )
        {
            EnterNumberForReversing();
        }
        else if (choiceOfUser == 2) 
        {
            EnterNumbersForAverage();
        }
        else
        {
            EnterNumbersForEquation();
        }
    }
}