//Write a program that prints to the console which day of the week is today. Use System.DateTime.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class WhichDayIsIt
{
    static void Main(string[] args)
    {
        var today = DateTime.Now.DayOfWeek;
        Console.WriteLine("Today is " + today);
    }
}