//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBetweenDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string start = "27.02.2006";
            string end = "3.03.2006";

            DateTime startDate = DateTime.ParseExact(start, "d.MM.yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(end, "d.MM.yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine((endDate - startDate).TotalDays);
        }
    }
}
