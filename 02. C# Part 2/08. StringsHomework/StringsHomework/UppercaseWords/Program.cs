//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. The tags cannot be nested. 
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.
//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        int startIndex = 0;
        int endIndex = 0;

        for (int i = 0; i < input.Length - 8; i++)
        {
            if (input.Substring(i, 8) == "<upcase>")
            {
                startIndex = i + 8;
                i = startIndex;
            }
            if (input.Substring(i, 9) == "</upcase>")
            {
                endIndex = i;
                int length = endIndex - startIndex;
                string upperStr = input.Substring(startIndex, length).ToUpper();
                input = input.Remove(startIndex, length);
                input = input.Insert(startIndex, upperStr);
                input = input.Remove(startIndex - 8, 8);
                input = input.Remove(endIndex - 8, 9);
            }
        }

        Console.WriteLine(input);
    }
}