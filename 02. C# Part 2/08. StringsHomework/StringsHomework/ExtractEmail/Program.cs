//Write a program for extracting all email addresses from given text. All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Please contact us by phone (+359 222 222 222) or by email at example@abv.bg or at baj.ivan@yahoo.co.uk.".Trim(' ', ',');
            string[] update = text.Split(new char[] { ' ', ',', ':', '?', '!', '-', '_' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < update.Length; i++)
            {
                if (
                    update[i].IndexOf("@") != -1 &&
                    update[i].IndexOf("@") != 0 &&
                    update[i].IndexOf(".com") != -1 ||
                    update[i].IndexOf(".uk") != -1 ||
                    update[i].IndexOf(".bg") != -1)
                {
                    Console.WriteLine("The email: \"{0}\" Printed to the \"Emails.txt\"", update[i]);
                }
            }
        }
    }
}