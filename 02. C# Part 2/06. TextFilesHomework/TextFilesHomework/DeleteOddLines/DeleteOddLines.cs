//Write a program that deletes from given text file all odd lines. The result should be in the same file.
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
        string filename = @"..\..\testfile.txt";
        StreamReader reader = new StreamReader(filename);
        string row = reader.ReadLine();
        int count = 0;
        List<string> rows = new List<string>();
        while (row != null)
        {

            if (count % 2 == 0)
            {
                rows.Add(row);
            }
            row = reader.ReadLine();
            count++;
        }
        reader.Close();

        StreamWriter writer = new StreamWriter(filename, false);
        for (int i = 0; i < rows.Count; i++)
        {
            writer.WriteLine(rows[i]);
        }
        writer.Close();

    }
}