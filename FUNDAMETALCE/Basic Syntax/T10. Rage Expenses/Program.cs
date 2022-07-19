using System;

namespace T10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            int games = 1;

            while (games <= lostGCount)
            {
                if (games % 2 == 0)
                {
                    totalPrice += headsetPrice;
                }
                if (games % 3 == 0)
                {
                    totalPrice += mousePrice;
                }
                if (games % 6 == 0)
                {
                    totalPrice += keyboardPrice;
                }
                if (games % 12 == 0)
                {
                    totalPrice += displayPrice;
                }
                games++;
            }
            Console.WriteLine($"Rage expenses: {totalPrice:f2} lv.");
        }
    }
}
