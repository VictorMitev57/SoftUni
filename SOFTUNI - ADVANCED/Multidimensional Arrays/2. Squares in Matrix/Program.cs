using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split(" ");
            int rows = int.Parse(nums[0]);
            int cols = int.Parse(nums[1]);

            string[,] charMatrix = new string[rows, cols];

            FillMatrix(charMatrix);

            int count = 0;

            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (charMatrix[row, col] == charMatrix[row, col + 1] &&
                        charMatrix[row, col] == charMatrix[row + 1, col ] &&
                        charMatrix[row, col] == charMatrix[row + 1, col+ 1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }

        private static void FillMatrix(string[,] charMatrix)
        {
            for (int row = 0; row < charMatrix.GetLength(0); row++)
            {
                string[] rowData = Console.ReadLine().Split(" ");
                for (int col = 0; col < charMatrix.GetLength(1); col++)
                {
                    charMatrix[row, col] = rowData[col];
                }
            }
        }
    }
}