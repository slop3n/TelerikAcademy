//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main()
    {
        using (StreamReader reader = new StreamReader(@"..\..\names.txt"))
        {
            List<string> names = new List<string>();

            for (string currentName = reader.ReadLine(); currentName != null; currentName = reader.ReadLine())
            {
                names.Add(currentName);
            }

            names.Sort();

            using (StreamWriter writer = new StreamWriter(@"..\..\sorted.txt"))
            {
                foreach (string name in names) writer.WriteLine(name);
            }
        }
    }
}