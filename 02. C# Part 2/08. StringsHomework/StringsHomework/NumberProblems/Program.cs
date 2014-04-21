//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. Format the output aligned right in 15 symbols
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number.ToString("F"));
            Console.WriteLine(number.ToString("X"));
            Console.WriteLine(number.ToString("P"));
            Console.WriteLine(number.ToString("E"));
            Console.WriteLine(number.ToString("D15"));
        }
    }
}
