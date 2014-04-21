//Write a program that concatenates two text files into another text file.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ConcatenateTwoTextFiles
{
    static void Main(string[] args)
    {
        StreamReader fileOne = new StreamReader(@"..\..\testOne.txt");
        StreamReader fileTwo = new StreamReader(@"..\..\testTwo.txt");
        using (fileOne)
        {
            StreamWriter write = new StreamWriter(@"..\..\concatenated.txt", false);
            using (write)
            {
                string copy;
                while ((copy = fileOne.ReadLine()) != null)
                {
                    write.WriteLine(copy);
                }
            }
        }
        using (fileTwo)
        {
            StreamWriter write = new StreamWriter(@"..\..\concatenated.txt", true);
            using (write)
            {
                string copy;
                while ((copy = fileTwo.ReadLine()) != null)
                {
                    write.WriteLine(copy);
                }
            }
        }
    }
}