//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArray = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(inputArray);
            foreach (var item in inputArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
