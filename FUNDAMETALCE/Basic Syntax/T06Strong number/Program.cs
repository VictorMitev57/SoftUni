using System;

namespace T06Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int save = num;
            int sum = 0;
            int factorial = 1;

            while (factorial == 1)
            {
                int currNUm = num % 10;
                int newNum = num / 10;
                for (int i = 1; i <= currNUm; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
                if (newNum == 0)
                {
                    num = save;
                    break;
                }
                num = newNum;
                factorial = 1;
            }
            if (num == sum)
            {
                Console.WriteLine("yes");
            }
            else if (num != sum)
            {
                Console.WriteLine("no");
            }
        }
    }
}
