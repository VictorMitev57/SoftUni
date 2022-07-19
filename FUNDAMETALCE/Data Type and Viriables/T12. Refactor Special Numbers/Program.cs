using System;

namespace T12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args, int ch)
        {
            int number = int.Parse(Console.ReadLine());
            int takova = 1;
            double totalresult;
            bool result;
            for (int i = 1; i <= number; i++)
            {
                while (i > 0)
                {
                    totalresult = i % 10;
                    totalresult += i / 10;
                    result = (totalresult == 5) || (totalresult == 7) || (totalresult == 11);
                    Console.WriteLine($"{takova} -> {result}");
                    i = takova;
                }
            }
        }
    }
}
