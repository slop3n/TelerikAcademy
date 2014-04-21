//Write a method GetMax() with two parameters that returns the bigger of two integers. Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter 3 numbers");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        Console.WriteLine("The maximal number is " + GetMax(GetMax(first, second), third));        
    }
    static int GetMax(int firstNum, int secondNum)
    {
        if (firstNum > secondNum)
        {
            return firstNum;
        }
        else
        {
            return secondNum;
        }
    }
}