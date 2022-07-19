using System;
using System.Linq;

namespace _01._Sum_Matrix_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] demensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int[,] matrix = new int[demensions[0], demensions[1]];

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {

                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = line[cols];
                }
            }

            int sum = 0;
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    sum += matrix[rows, cols];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
