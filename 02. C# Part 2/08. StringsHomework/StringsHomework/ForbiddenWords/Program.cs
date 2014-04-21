//We are given a string containing a list of forbidden words and a text containing some of these words. Write a program that replaces the forbidden words with asterisks. 	
//Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
//Words: "PHP, CLR, Microsoft"
//The expected result:
//********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string[] forbiddenWords = "PHP, CLR, Microsoft".Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                input = input.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
            }
            Console.WriteLine(input);
        }
    }
}
