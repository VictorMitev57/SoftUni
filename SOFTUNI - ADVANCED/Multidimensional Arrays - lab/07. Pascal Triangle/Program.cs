using System;

namespace _07._Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long rows = int.Parse(Console.ReadLine());
            long[][] triangle = new long[rows][];

            for (int row = 0; row < rows; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;
                triangle[row][triangle[row].Length - 1] = 1;
                for (int col = 1; col < row ; col++)
                {
                    triangle[row][col] =
                        triangle[row - 1][col] + triangle[row - 1][col - 1];
                }
            }
            foreach (long[] row in triangle)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
