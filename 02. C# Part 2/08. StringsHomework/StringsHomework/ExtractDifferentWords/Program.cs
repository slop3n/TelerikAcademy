//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractDifferentWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.".Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            var dict = new Dictionary<string, int>();

            foreach (var word in text)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word] = dict[word] + 1;
                }
                else
                {
                    dict.Add(word, 1);
                }
            }

            foreach (var word in dict)
            {
                Console.WriteLine("{0, -10} - {1} times", word.Key, word.Value);
            }
        }
    }
}
