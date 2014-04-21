//Write a program that extracts from a given text all sentences containing given word.
//Example: The word is "in". The text is:
//We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//The expected result is:
//We are living in a yellow submarine.
//We will move out of it in 5 days.
//Consider that the sentences are separated by "." and the words – by non-letter symbols.
using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days. This substring In will not be printed";
        string substring = "in";
        string[] inputArray = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < inputArray.Length; i++)
        {
            string[] currentArray = inputArray[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < currentArray.Length; j++)
            {
                if (currentArray[j] == substring)
                {
                    for (int k = 0; k < currentArray.Length; k++)
                    {
                        Console.Write(currentArray[k] + " ");
                        if (k == currentArray.Length -1)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}