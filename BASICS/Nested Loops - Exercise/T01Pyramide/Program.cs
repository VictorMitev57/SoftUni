using System;

namespace T01Pyramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentNum = 0;
            bool flag = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    currentNum++;
                    if (currentNum > n)
                    {
                        flag = true;
                        break;
                    }
                    Console.Write(currentNum + " ");
                }
                if (flag == true)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
