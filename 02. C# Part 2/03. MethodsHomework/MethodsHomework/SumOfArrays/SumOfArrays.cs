//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]). Each of the numbers that will be added could have up to 10 000 digits.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SumOfArrays
{


    static void Main(string[] args)
    {
        byte[] firstArray = { 9, 4, 1, 9 };
        byte[] secondArray = { 1, 5, 6, 7, 9, 9, 9 };

        string total = SumArrays(firstArray, secondArray);
        Console.WriteLine(total);
    }

    private static string SumArrays(byte[] firstArray, byte[] secondArray)
    {
        List<byte> maxArray = new List<byte>();
        List<byte> minArray = new List<byte>();
        if (firstArray.Length > secondArray.Length)
        {
            maxArray.AddRange(firstArray);
            minArray.AddRange(secondArray);
        }
        else
        {
            maxArray.AddRange(secondArray);
            minArray.AddRange(firstArray);
        }

        int minLength = minArray.Count;
        int maxLength = maxArray.Count;
        int addition = 0;
        int sum;
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < minLength; i++)
        {
            sum = minArray[i] + maxArray[i] + addition;
            if (sum >= 10)
            {
                addition = 1;
                sum = sum % 10;
                result.Append(sum);
            }
            else
            {
                result.Append(sum);
                addition = 0;
            }
        }

        for (int j = minLength; j < maxLength; j++)
        {
            sum = maxArray[j] + addition;
            if (sum >= 10)
            {
                addition = 1;
                sum = sum % 10;
                result.Append(sum);
            }
            else
            {
                result.Append(sum);
                addition = 0;
            }
        }
        if (addition == 1)
        {
            result.Append(1);
        }
        char[] reversed = (result.ToString()).ToCharArray();
        result.Clear();
        for (int i = reversed.Length - 1; i >= 0; i--)
        {
            result = result.Append(reversed[i]);
        }
        return result.ToString();
    }
}
