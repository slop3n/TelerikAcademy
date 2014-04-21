//Write a program that generates and prints to the console 10 random values in the range [100, 200].
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RandomNumbers
{
    static void Main(string[] args)
    {
        Random number = new Random();
        int[] arrayOfRandomIntegers = new int[10];
        for (int i = 0; i < arrayOfRandomIntegers.Length; i++)
        {
            arrayOfRandomIntegers[i] = number.Next(100, 200);
        }
        foreach (var value in arrayOfRandomIntegers)
	    {
		     Console.WriteLine(value);
	    }
    }
}