using System;

namespace T10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            int result = 0;
            while (number > 0)
            {
                result = number % 10;
                if (result % 2 == 0)
                {
                    sum += result;
                }
                number /= 10;
            }

            return sum;
        }

        static int GetSumOfOddDigits(int number)
        {
            number = Math.Abs(number);
            int sum = 0;
            int result = 0;
            while (number > 0)
            {
                result = number % 10;
                if (result % 2 != 0)
                {
                    sum += result;
                }
                number /= 10;
            }

            return sum;
        }

        static int  GetMultipleOfEvenAndOdds(int number)
        {
            int number1 = GetSumOfEvenDigits(number);
            int number2 = GetSumOfOddDigits(number);
            int multiplication = number1 * number2;
            return multiplication;
        }
    }
}
