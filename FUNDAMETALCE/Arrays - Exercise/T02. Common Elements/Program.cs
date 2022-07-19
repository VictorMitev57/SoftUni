using System;
using System.Linq;

namespace T02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(" ");
            string[] arr2 = Console.ReadLine().Split(" ");

            foreach (string elementsTwo in arr2)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    string elementsOne = arr1[i];
                    if (elementsTwo == elementsOne)
                    {
                        Console.Write($"{elementsOne} ");
                    }
                }
            }
        }
    }
}
