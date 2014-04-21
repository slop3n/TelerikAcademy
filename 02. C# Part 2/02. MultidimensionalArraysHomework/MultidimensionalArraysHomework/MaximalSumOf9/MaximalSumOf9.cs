//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaximalSumOf9
{
    static void Main(string[] args)
    {
        
        int[,] matrix = {
        {5,4,3,6,8,4,3,7,7,6},
        {2,5,9,6,5,4,8,3,5,4},
        {8,9,8,7,4,2,3,6,5,1},
        {5,6,5,7,4,8,9,6,3,2},
        {5,4,7,8,9,6,3,2,1,5}
                        };
        int sum = int.MinValue;
        int maxSum = int.MinValue;
        for (int row = 0; row < matrix.GetLength(0)-2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum>maxSum)
                {
                    maxSum = sum;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}