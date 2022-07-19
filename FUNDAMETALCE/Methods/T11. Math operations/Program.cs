using System;

namespace T11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            int num2 = int.Parse(Console.ReadLine());

            int sum = Operation(operation, num1, num2);
            Console.WriteLine(sum);
        }

        static int Operation(string operation, int num1, int num2)
        {
            int sum = 0;
            if (operation == "/")
            {
                sum = num1 / num2;
            }
            else if(operation == "*")
            {
                sum = num1 * num2;
            }
            else if (operation == "+")
            {
                sum = num1 + num2;
            }
            else if (operation == "-")
            {
                sum = num1 - num2;
            }
            return sum;
        }
    }
}
