using System;

namespace T09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();
            GetMax(operation, num1, num2);

        }

        static int GetMax(string operation, string num1, string num2)
        {
            int result = 0;
            if (operation == "int")
            {
                int realNum1 = int.Parse(num1);
                int realNum2 = int.Parse(num2);
                if (realNum1 > realNum2)
                {
                    Console.WriteLine(realNum1);
                    result = realNum1;
                }
                else
                {
                    Console.WriteLine(realNum2);
                    result = realNum2;

                }

            }
            else if (operation == "char")
            {
                char realNum1 = char.Parse(num1);
                char realNum2 = char.Parse(num2);
                if (realNum1 > realNum2)
                {
                    Console.WriteLine(realNum1);
                    result = realNum1;

                }
                else
                {
                    Console.WriteLine(realNum2);
                    result = realNum2;

                }

            }
            else if (operation == "string")
            {
                if (num1.CompareTo(num2) > 0)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine(num2);
                }
            }
            
            return result;
        }
    }
}

