using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintMatrixVar3
{
    static void Main(string[] args)
    {
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];        
        int temp = 1;

        for (int row = matrixSize - 1; row >= 0; row--)
        {
            if (matrixSize - 1 > row)
            {
                int tempCol = 0;
                int tempRow = row;
                for (int i = (matrixSize - 1) - row; i >= 0; i--)
                {
                    matrix[tempRow, tempCol] = temp++;
                    tempCol++;
                    tempRow++;
                }
            }
            else
            {
                matrix[row, 0] = temp++;
            }
        }

        for (int col = 1; col < matrixSize; col++)
        {
            if ((matrixSize - 1) > col)
            {
                int tempCol = col;
                int tempRow = 0;
                for (int i = (matrixSize - 1) - col; i >= 0; i--)
                {
                    matrix[tempRow, tempCol] = temp++;
                    tempCol++;
                    tempRow++;
                }
            }
            else
            {
                matrix[0, col] = temp;
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