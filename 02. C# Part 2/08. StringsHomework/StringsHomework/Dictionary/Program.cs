//A dictionary is stored as a sequence of text lines containing words and their explanations. Write a program that enters a word and translates it by using the dictionary. Sample dictionary:
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionary = {".NET – platform for applications from Microsoft", 
                                   "CLR – managed execution environment for .NET",
                                   "namespace – hierarchical organization of classes" };
            string input = "CLR";
            foreach (string line in dictionary)
            {
                if (line.IndexOf(input) == 0)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
