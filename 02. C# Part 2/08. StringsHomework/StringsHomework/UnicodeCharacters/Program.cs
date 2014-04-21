//Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. Sample input: Hi!
//Expected output: \u0048\u0069\u0021

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Hi!";
            foreach (var symbol in input)
            {
                Console.WriteLine("\\u{0:X4}", (int)symbol);
            }
        }
    }
}
