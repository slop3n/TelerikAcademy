//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class PrintFromFile
{
    static void Main(string[] args)
    {
        string filePath = @"..\..\test.txt";
        StreamReader textFile = new StreamReader(filePath);
        using (textFile)
        {
            Console.WriteLine(textFile.ReadToEnd());
        }
    }
}