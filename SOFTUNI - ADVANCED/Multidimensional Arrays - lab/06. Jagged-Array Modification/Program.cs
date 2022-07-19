using System;
using System.Linq;

namespace _06._Jagged_Array_Modification
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
            while (true)
            {
                string[] command = Console.ReadLine().Split();
                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                    {
                        
                        jagged[row][col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }

                }
                if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);

                    if (row >= 0 && row < jagged.Length && col >= 0 && col < jagged[row].Length)
                    {

                        jagged[row][col] -= value;
                    }
                    else
                    {
                      
                        Console.WriteLine("Invalid coordinates");
                    }
                }
            }

            //// PrintMatrix
            ///
                foreach (int[] row in jagged)
                {
                Console.WriteLine(string.Join(" ", row));
                }
            
        }
    }
}
