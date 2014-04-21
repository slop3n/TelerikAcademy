//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LastDigitOfNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number");
        int num = int.Parse(Console.ReadLine());
        Word(num);
    }

    static void Word(int number)
    {
        int newNum = number % 10;
        string[] numNames = {  "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        Console.WriteLine(numNames[newNum]);
    }
}