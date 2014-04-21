//Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SquareRoot
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        try
        {
            double root = Math.Sqrt(int.Parse(input));
            Console.WriteLine("The square root of this number is: " + root);
        }
        catch (FormatException)
        {
            Console.WriteLine("You have entered invalid integer!");
        }
        finally
        {
            Console.WriteLine("Good bye!");
        } 
    }
}