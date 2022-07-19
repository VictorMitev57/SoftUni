using System;

namespace TO1_SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int totatTime = 0;
            int FirstTime = int.Parse(Console.ReadLine());
            int SecondTime = int.Parse(Console.ReadLine());
            int ThirdTime = int.Parse(Console.ReadLine());
            totatTime = FirstTime + SecondTime + ThirdTime;


            if (totatTime >= 60 )
            {
               int minutes = totatTime / 60;
                int seconds = totatTime % 60;
                Console.WriteLine($"{minutes}:{seconds:d2}");
            }
            else
            {
                int minutes = 0;
                int seconds = totatTime;
                Console.WriteLine($"{minutes}:{seconds:d2}");
            }
            

        }
    }
}
