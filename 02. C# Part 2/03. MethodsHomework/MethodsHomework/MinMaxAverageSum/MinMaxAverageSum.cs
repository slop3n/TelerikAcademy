//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int[] setOfIntegers = { 1, 5, 6, 8, 9 };
        Console.WriteLine(Minimum(setOfIntegers));
        Console.WriteLine(Maximum(setOfIntegers));
        Console.WriteLine(Average(setOfIntegers));
        Console.WriteLine(Sum(setOfIntegers));
        Console.WriteLine(Product(setOfIntegers));

    }

    static int Minimum(int[] array)
    {
        int minimum = int.MaxValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimum)
            {
                minimum = array[i];
            }
        }
        return minimum;
    }

    static int Maximum(int[] array)
    {
        int maximum = int.MinValue;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximum)
            {
                maximum = array[i];
            }
        }
        return maximum;
    }

    static double Average(int[] array)
    {
        double average = 0;
        for (int i = 0; i < array.Length; i++)
        {
            average += array[i];
        }
        average = average / (array.Length);
        return average;
    }

    static int Sum(int[] array)
    {
        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static int Product(int[] array)
    {
        int product = 1;
        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        } 
        return product;
    }
}