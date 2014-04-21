//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractDifferentWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string previousWord = text[0];
            int counter = 1;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    
                }
            }
        }
    }
}
