// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("How much elements will the arrays have");
        int arrayLenght = int.Parse(Console.ReadLine());
        char[] arrayOne = new char[arrayLenght];
        char[] arrayTwo = new char[arrayLenght];
        for (int i = 0; i < arrayLenght; i++)
        {
            Console.WriteLine("Enter elements in arrays one and two:");
            arrayOne[i] = char.Parse(Console.ReadLine());
            arrayTwo[i] = char.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrayOne.Length; i++)
        {
            if (arrayOne[i] == arrayTwo[i])
            {
                Console.WriteLine("The elements on position {0} are the same",i);
            }
            else
            {
                Console.WriteLine("The elements on position {0} are different",i);
            }
        }

    }
}
