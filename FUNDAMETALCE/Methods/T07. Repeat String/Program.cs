using System;

namespace T07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string result = RepeatString(str, n);
            Console.WriteLine(result);
        }

        static string RepeatString(string str, int n)
        {
            
            for (int i = 1; i < n; i++)
            {
                Console.Write(str);
            }

            return str;
        }
    }
}
