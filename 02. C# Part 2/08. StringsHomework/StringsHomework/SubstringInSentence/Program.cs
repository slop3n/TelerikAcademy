//Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string input = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days";
        string substring = "in";
        int counter = 0;
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (input.Substring(i, substring.Length).ToLower() == substring)
            {
                counter++;
            }            
        }
        Console.WriteLine("The number of times this substring is met is: " + counter);
    }
}