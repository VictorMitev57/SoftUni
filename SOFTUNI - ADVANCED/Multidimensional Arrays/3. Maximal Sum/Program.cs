using System;
using System.Collections.Generic;
using System.Linq;


namespace _3._Maximal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] demensions = Console.ReadLine().Split();
            int rows = int.Parse(demensions[0]);
            int cols = int.Parse(demensions[1]);
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            int maxSum = int.MinValue;
            string best3X3 = "";

            for (int row = 0; row < rows -2; row++)
            {
                for (int col = 0; col < cols -2 ; col++)
                {
                    int sum =
                        matrix[row, col] +
                        matrix[row, col + 1] +
                        matrix[row, col + 2] +
                        matrix[row + 1, col] +
                        matrix[row + 1, col + 1] +
                        matrix[row + 1, col + 2] +
                        matrix[row + 2, col] +
                        matrix[row + 2, col + 1] +
                        matrix[row + 2, col + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        best3X3 =
                              matrix[row, col] + " " + matrix[row, col + 1] + " " + matrix[row, col + 2] + "\r\n" +
                              matrix[row + 1, col] + " " + matrix[row + 1, col + 1] + " " + matrix[row + 1, col + 2] + "\r\n" +
                              matrix[row + 2, col] + " " + matrix[row + 2, col + 1] + " " + matrix[row + 2, col + 2];
                    }
                }

            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine(best3X3);
        }

    }
}