using System;
using System.Linq;

namespace _06._Jagged_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jagged = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jagged[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }


            for (int row = 0; row < rows - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    jagged[row] = jagged[row].Select(el => el * 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(el => el * 2).ToArray();
                }
                else
                {
                    jagged[row] = jagged[row].Select(el => el / 2).ToArray();
                    jagged[row + 1] = jagged[row + 1].Select(el => el / 2).ToArray();
                }
            }
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "Add")
                {
                    int currRow = int.Parse(command[1]);
                    int currCol = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (currRow >= 0 && currRow <= rows && currCol >= 0 && currCol <= jagged[currRow].Length)
                    {
                        jagged[currRow][currCol] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int currRow = int.Parse(command[1]);
                    int currCol = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (currRow >= 0 && currRow < rows && currCol >= 0 && currCol < jagged[currRow].Length)
                    {
                        jagged[currRow][currCol] -= value;
                    }
                }
                else if (command[0] == "End")
                {
                    break;
                }
            }

            foreach (int[] row in jagged)
            {
                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
