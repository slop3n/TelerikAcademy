using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintMatrixVar1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of the matrix");
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];
        int temp = 1;
        for (int col = 0; col < matrixSize; col++)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                matrix[row, col] = temp++;
            }
        }
    
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}