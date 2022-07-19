using System;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine()); // 2
            if (multiplier == 0) 
            {
                Console.WriteLine(0);
                return;
            }
            
            StringBuilder sb = new StringBuilder();
            int reminder = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                int currDigit = int.Parse(input[i].ToString()); // 23 => 32
                int product = currDigit * multiplier + reminder;// 3 * 2 = 6
                int result = product % 10; 
                reminder = product / 10; //6  
                sb.Insert(0, result);
            }

            if (reminder > 0)
            {
                sb.Insert(0, reminder);
            }

            Console.WriteLine(sb);
        }
    }
}
