//Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days";
        string key = "submarine";
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < text.Length; i++)
        {
            int counter = 0;
            result.Append((char)((int)(text[i]) ^ (int)(key[counter])));
            if (counter + 1 == key.Length)
            {
                counter = 0;
            }
            counter++;
        }

        Console.WriteLine("The encrypted string is");
        Console.WriteLine(result.ToString());
        StringBuilder decrypt = new StringBuilder();
        
        for (int i = 0; i < text.Length; i++)
        {
            int counter = 0;
            decrypt.Append((char)((int)(result[i]) ^ (int)(key[counter])));
            if (counter + 1 == key.Length)
            {
                counter = 0;
            }
            counter++;
        }

        Console.WriteLine("The decrypted string is");
        Console.WriteLine(decrypt.ToString());
    }
}