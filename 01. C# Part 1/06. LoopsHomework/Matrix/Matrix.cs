using System;

class Matrix
{

    //Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix

    static void Main()
    {
        int number;
        Console.WriteLine("Enter Number: ");
        bool isNInt = int.TryParse(Console.ReadLine(), out number);

        if (isNInt && number > 0)
        {
            string result = "";

            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j < number + i; j++)
                {
                    result += j;

                    result += "   ";
                }
                result += "\n";
            }

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Not valid entry");
        }
    }
}