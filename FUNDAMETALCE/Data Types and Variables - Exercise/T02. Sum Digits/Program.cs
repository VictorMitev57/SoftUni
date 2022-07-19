using System;

namespace T02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int result = 0;
            while (number != 0)
            {
                result = number % 10;
                number  /= 10;
                sum += result;
            }

            Console.WriteLine(sum);
        }
    }
}
