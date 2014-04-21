//Write a program to convert binary numbers to hexadecimal numbers (directly).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BinaryToHexadecima
{
    static void Main()
    {
        Console.WriteLine("Enter binary number. Ex: 0101");
        string binaryNumber = Console.ReadLine();
        Console.WriteLine("The converted number is: {0}", BinToHex(binaryNumber));
    }

    static string BinToHex(string binaryNum)
    {
        int hexLength = binaryNum.Length;
        StringBuilder hex = new StringBuilder();

        for (int i = 0; i < hexLength; i = i + 4)
        {
            switch (binaryNum.Substring(i, 4))
            {
                case "1010": hex.Append("A"); break;
                case "1011": hex.Append("B"); break;
                case "1100": hex.Append("C"); break;
                case "1101": hex.Append("D"); break;
                case "1110": hex.Append("E"); break;
                case "1111": hex.Append("F"); break;
                case "0000": hex.Append("0"); break;
                case "0001": hex.Append("1"); break;
                case "0010": hex.Append("2"); break;
                case "0011": hex.Append("3"); break;
                case "0100": hex.Append("4"); break;
                case "0101": hex.Append("5"); break;
                case "0110": hex.Append("6"); break;
                case "0111": hex.Append("7"); break;
                case "1000": hex.Append("8"); break;
                case "1001": hex.Append("9"); break;
            }
        }
        return hex.ToString();
    }
}