using System;
using System.Linq;

namespace _02._Sum_Matrix_Columns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] demensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = demensions[0];
            int cols = demensions[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int sum = 0;
            for (int c = 0; c < matrix.GetLength(1); c++)
            {
                sum = 0;
                for (int r = 0; r < matrix.GetLength(0); r++)
                {
                    sum += matrix[r, c];
                }
                Console.WriteLine(sum);
            }
            
        }
    }
}
