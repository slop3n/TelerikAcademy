//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with '*'. Print the result string into the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string result = input;
        if (input.Length < 20)
        {
            for (int i = 0; i < 20 - input.Length; i++)
            {
                result += "*";
            }
        }
        Console.WriteLine(result);
    }
}