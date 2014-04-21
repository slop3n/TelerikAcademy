//Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintIndexOfElementsInWord
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter word with lowercase letters:");
        string input = Console.ReadLine();
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(i+97);
        }
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write(Array.IndexOf(alphabet, input[i]));
            if (i < input.Length - 1)
            {
                Console.Write(", ");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}