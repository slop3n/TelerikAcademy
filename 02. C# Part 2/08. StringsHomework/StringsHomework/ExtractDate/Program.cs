//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractDate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = "Some random useless dates 01.02.2013 and this 02.10.2013 or this 20.05.2032 this too 10.10.2012".Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in text)
            {
                try
                {
                    DateTime date = DateTime.ParseExact(word, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    string dateCanada = date.ToString("dd/MM/yy", CultureInfo.InvariantCulture);
                    Console.WriteLine(dateCanada);
                }
            }
        }
    }
}
