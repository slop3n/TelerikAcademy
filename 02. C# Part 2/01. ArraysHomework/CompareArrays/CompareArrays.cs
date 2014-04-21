//Write a program that reads two arrays from the console and compares them element by element.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter how much elements you want in arrays one and two ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] arrayOne = new int[arrayLenght];
        int[] arrayTwo = new int[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            Console.WriteLine("Enter values for index number {0}, in array one and array two", i);
            arrayOne[i] = int.Parse(Console.ReadLine());
            arrayTwo[i] = int.Parse(Console.ReadLine());

        }
        for (int i = 0; i < arrayLenght; i++)
        {
            if (arrayOne[i] > arrayTwo[i])
            {
                Console.WriteLine("Element {0} in the first array is bigger than the element in the second array", i);
            }
            else if(arrayTwo[i] > arrayOne[i])
            {
                Console.WriteLine("Element {0} in the second array is bigger than the element in the first array",i);
            }
            else
            {
                Console.WriteLine("Both elements {0} have the same value",i);
            }
        }
    }
}