using System;
using System.Linq;

namespace T04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] chars = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < chars.Length / 2; i++)
            {
                string temp = chars[i];
                chars[i] = chars[chars.Length - i -1];
                chars[chars.Length - i - 1] = temp;
            }

            Console.WriteLine(string.Join(" ", chars));
        }
    }
}
