using System;
using System.Collections.Generic;
using System.Linq;

namespace T03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();

            int biggestNumber = list1.Count;
            if (biggestNumber < list2.Count)
            {
                biggestNumber = list2.Count;
            }

            for (int i = 0; i < biggestNumber; i++)
            {
                if (list1.Count > i)
                {
                    result.Add(list1[i]);
                }
                if (list2.Count > i)
                {
                    result.Add(list2[i]);
                }

            }
            Console.Write(string.Join(" ", result));
        }
    }
}
