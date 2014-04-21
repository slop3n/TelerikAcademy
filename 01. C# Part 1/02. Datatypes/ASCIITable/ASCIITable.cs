using System;

class ASCIITable
{
    // Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.

    static void Main()
    {
        for (int i = 0; i < 128; i++)
        {
            Console.WriteLine("The ASCII code for {0} is {1}", (char)i, i);
        }
    }
}
