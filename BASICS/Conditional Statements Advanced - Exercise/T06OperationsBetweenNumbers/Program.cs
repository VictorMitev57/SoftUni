using System;

namespace T06OperationsBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double sum = 0;
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    sum = n1 + n2;
                    if (sum %2 ==0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {sum} - odd");
                    }
                    break;
                case "-":
                    sum = n1 - n2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {sum} - odd");
                    }
                    break;
                case "*":
                    sum = n1 * n2;
                    if (sum % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {sum} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {sum} - odd");
                    }
                    break;
                case "/":
                    if  (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    if (n2 != 0)
                    {
                        Console.WriteLine($"{n1} / {n2} = {(n1/n2):F2}");
                    }
                    break;
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    if (n2 != 0)
                    {
                        sum = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {sum}");
                    }
                    break;
            }
        }
    }
}
