using System;
using System.Linq;

namespace _05._Square_with_Maximum_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[demensions[0], demensions[1]];
            int rowsCount = demensions[0];
            int colsCount = demensions[1];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int maxSum = int.MinValue;
            string bestMtrix = "";
            for (int rows = 0; rows < rowsCount - 1; rows++)
            {
                for (int cols = 0; cols < colsCount - 1; cols++)
                {
                    int sum =
                        matrix[rows, cols] +
                        matrix[rows, cols + 1] +
                        matrix[rows + 1, cols] +
                        matrix[rows + 1, cols + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestMtrix =
                                matrix[rows, cols] + " " + matrix[rows, cols + 1] + "\r\n" + 
                                matrix[rows + 1, cols] + " " + matrix[rows + 1, cols + 1];

                    }
                }
            }
            Console.WriteLine(bestMtrix);
            Console.WriteLine(maxSum);
        }
    }
}
