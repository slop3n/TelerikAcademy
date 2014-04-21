//reverses the words in given sentence. Example: "C# is not C++, not PHP and not Delphi!"  "Delphi not and PHP, not C++ not is C#!".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "C# is not C++, not PHP and not Delphi!";
            string[] arguments = new string[] { " ", ",", "!" };
            string[] splittedText = text.Split(arguments, StringSplitOptions.RemoveEmptyEntries);

            for (int i = splittedText.Length - 1; i >= 0; i--)
            {
                Console.Write(splittedText[i] + " ");

                if (splittedText[i] == "PHP")
                {
                    Console.Write(",");
                }
            } 
            Console.WriteLine("!");
        }
    }
}
