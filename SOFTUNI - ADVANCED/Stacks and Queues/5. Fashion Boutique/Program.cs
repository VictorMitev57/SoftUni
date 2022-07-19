using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> clothesOrdered = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            int capacityOfReck = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>(clothesOrdered);
            int sumOfClothes = 0;
            int reckCount = 1;

            while (clothes.Count > 1)
            {
                sumOfClothes += clothes.Peek();
                clothes.Pop();
                if (capacityOfReck == sumOfClothes)
                {
                    reckCount++;
                    sumOfClothes = 0;
                }

                else if (capacityOfReck > sumOfClothes)
                {
                    int ostavashtoMqsto = capacityOfReck - sumOfClothes;
                    if (clothes.Peek() > ostavashtoMqsto)
                    {
                        reckCount++;
                        sumOfClothes = 0;
                    }
                }

            }
            Console.WriteLine(reckCount);
        }
    }
}
