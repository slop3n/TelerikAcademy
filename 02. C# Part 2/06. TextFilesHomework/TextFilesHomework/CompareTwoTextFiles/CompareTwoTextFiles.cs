//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different. Assume the files have equal number of lines.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CompareTwoTextFiles
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader fileOne = new StreamReader(@"..\..\FileOne.txt");
            StreamReader fileTwo = new StreamReader(@"..\..\FileTwo.txt");

            using (fileTwo)
            {
                using (fileOne)
                {
                    int equalsCount = 0;
                    int diffCount = 0;
                    string lineFile1 = fileOne.ReadLine();
                    string lineFile2 = fileTwo.ReadLine();
                    while (lineFile1 != null && lineFile2 != null)
                    {
                        if (lineFile1.Equals(lineFile2))
                        {
                            equalsCount++;
                        }
                        else
                        {
                            diffCount++;
                        }
                        lineFile1 = fileOne.ReadLine();
                        lineFile2 = fileTwo.ReadLine();
                    }
                    Console.WriteLine("Equal lines: {0}", equalsCount);
                    Console.WriteLine("Different lines: {0}", diffCount);
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine(e.Message);
        }
        catch (DirectoryNotFoundException)
        {
            Console.Error.WriteLine("Invalid directory in the file path.");
        }
        catch (IOException e)
        {
            Console.Error.WriteLine(e.Message);
        }

    }
}