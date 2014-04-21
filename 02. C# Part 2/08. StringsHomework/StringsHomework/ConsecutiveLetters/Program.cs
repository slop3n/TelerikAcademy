//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsecutiveLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            char previousSymbol = text[0];
            int counter = 1;

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == previousSymbol)
                {
                    counter++;
                }
                else
                {
                    result.Append(counter + previousSymbol.ToString());
                    counter = 1;
                }                
                previousSymbol = text[i];
            }

            result.Append(counter + previousSymbol.ToString());
            Console.WriteLine(result.ToString());
        }
    }
}
