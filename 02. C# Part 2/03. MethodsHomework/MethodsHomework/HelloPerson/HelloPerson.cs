//Write a method that asks the user for his name and prints “Hello, <name>” (for example, “Hello, Peter!”). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        Person();
    }
    static void Person()
    {
        string person = Console.ReadLine();
        Console.WriteLine("Hello " + person);
    }

}