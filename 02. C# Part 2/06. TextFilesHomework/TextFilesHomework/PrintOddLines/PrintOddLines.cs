//Write a program that reads a text file and prints on the console its odd lines.
using System;
using System.IO;

class PrintOddLines
{
    static void Main(string[] args)
    {
        string filePath = @"..\..\test.txt";
        StreamReader textFile = new StreamReader(filePath);
        using (textFile)
        {
            int lineNumber = 1;
            string line = textFile.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                lineNumber++;
                line = textFile.ReadLine();
            }
        }
    }
}