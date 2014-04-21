//Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IsItLeapYear
{
    static void Main(string[] args)
    {
        Console.Write("Enter year you want to check: ");
        int input = int.Parse(Console.ReadLine());
        bool isLeapYear = DateTime.IsLeapYear(input);
        if (isLeapYear)
        {
            Console.WriteLine("The entered year is a leap year");
        }
        else
        {
            Console.WriteLine("The entered year is NOT a leap year");
        }
    }
}