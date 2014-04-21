//You are given a sequence of positive integer values written into a string, separated by spaces. Write a function that reads these values from given string and calculates their sum. Example:
//		string = "43 68 9 23 318"  result = 461
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumOfSequence
{
    static void Main(string[] args)
    {
        string input = "5 4 10 421";
        int[] convertedString = input.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        int result = 0;
        for (int i = 0; i < convertedString.Length; i++)
        {
            result += convertedString[i];
        }
        Console.WriteLine(result);
    }

}