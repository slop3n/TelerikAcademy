//Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        StreamReader readFile = new StreamReader(@"..\..\ReadFile.txt");
        using (readFile)
        {
            int count = 1;
            string line;
            StreamWriter writeFile = new StreamWriter(@"..\..\WriteFile.txt");
            using (writeFile)
            {
                while ( (line = readFile.ReadLine()) != null)
                {
                    writeFile.Write("Line{0}: ", count);
                    writeFile.WriteLine(line);
                    count++;
                }
            }
        }
    }
}