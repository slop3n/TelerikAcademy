//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d).
//Example of incorrect expression: )(a+b)).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your expression");
        string input = Console.ReadLine();
        int counterOpenBracket = 0;
        int counterClosedBracked = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            { 
                counterOpenBracket++;
            }
            else if (input[i] == ')')
            {
                counterClosedBracked++;
            }
        }
        if (counterClosedBracked != counterOpenBracket)
        {
            Console.WriteLine("It's not a valid expression");
        }
        else if (input[0] == '+' || input[0] == '-' || input[0] == '/' || input[0] == '*' || input[0] == ')' || input[input.Length - 1] == '+' || input[input.Length - 1] == '-' || input[input.Length - 1] == '/' || input[input.Length - 1] == '*'|| input[ input.Length-1]=='(' )
        {
            Console.WriteLine("It's not a valid expression");  
        }
        else
        {
            Console.WriteLine("The expression is valid");
        }
    }
}