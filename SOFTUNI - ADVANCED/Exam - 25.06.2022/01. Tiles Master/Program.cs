using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Tiles_Master
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] areaWhiteTiles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] areaGreyTiles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> white = new Stack<int>();
            Queue<int> grey = new Queue<int>();

            int largeTile = 0;
            int sink = 0;
            int oven = 0;
            int countertop = 0;
            int wall = 0;
            int floor = 0;

            for (int i = 0; i < areaWhiteTiles.Length; i++)
            {
                white.Push(areaWhiteTiles[i]);
            }

            for (int i = 0; i < areaGreyTiles.Length; i++)
            {
                grey.Enqueue(areaGreyTiles[i]);
            }
            while (areaWhiteTiles.Length > 0 || areaGreyTiles.Length > 0)
            {
                if (white.Count == 0 || grey.Count == 0 )
                {
                    break;
                }
                if (white.Peek() == grey.Peek())
                {
                    largeTile = white.Peek() + grey.Peek();
                    //sink
                    if (largeTile == 40)
                    {
                        sink++;
                        white.Pop();
                        grey.Dequeue();
                    }
                    //oven
                    else if (largeTile == 50 )
                    {
                        oven++;
                        white.Pop();
                        grey.Dequeue();
                    }
                    //countertop
                    else if (largeTile == 60)
                    {
                        countertop++;
                        white.Pop();
                        grey.Dequeue();
                    }
                    //wall
                    else if (largeTile == 70)
                    {
                        wall++;
                        white.Pop();
                        grey.Dequeue();
                    }
                    //no current location
                    else
                    {
                        floor++;
                        white.Pop();
                        grey.Dequeue();
                    }
                }
                else if (white.Peek() != grey.Peek())
                {
                    int decreasedTiled = white.Peek();
                    decreasedTiled /= 2;
                    white.Pop();
                    white.Push(decreasedTiled);

                    int lastAtQueue = grey.Peek();
                    grey.Dequeue();
                    grey.Enqueue(lastAtQueue);
                }
            }

            if (white.Count > 0)
            {
                Console.WriteLine($"White tiles left: {String.Join(", ", white)}");
            }
            else
            {
                Console.WriteLine($"White tiles left: none");
            }

            if (grey.Count > 0)
            {
                Console.WriteLine($"Grey tiles left: {String.Join(", ", grey)}");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: none");
            }
            if (floor > 0)
            {
                Console.WriteLine($"Floor: {floor}");
            }
            if (countertop > 0)
            {
                Console.WriteLine($"Countertop: {countertop}");
            }
            if (oven > 0)
            {
                Console.WriteLine($"Oven: {oven}");
            }
            if (sink > 0)
            {
                Console.WriteLine($"Sink: {sink}");
            }
            if (wall > 0)
            {
                Console.WriteLine($"Wall: {wall}");
            }

        }
    }
}
