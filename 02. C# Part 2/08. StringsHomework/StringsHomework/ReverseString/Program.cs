//Write a program that reads a string, reverses it and prints the result at the console.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your sentence");
        string input = Console.ReadLine();
        char[] words = new char[input.Length];
        int position = 0;                

        for (int i = input.Length-1; i >= 0; i--)
        {
            words[position] = input[i];
                    position++;
        }
        Console.WriteLine("The reversed sentence is");
        foreach (var letter in words)
        {
            Console.Write(letter);
        }

        Console.WriteLine();
    }
}